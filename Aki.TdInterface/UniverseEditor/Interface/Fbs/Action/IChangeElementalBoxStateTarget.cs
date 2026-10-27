using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020062D8 RID: 25304
	public struct IChangeElementalBoxStateTarget : IFlatbufferObject
	{
		// Token: 0x1700BCE0 RID: 48352
		// (get) Token: 0x0602BBD1 RID: 179153 RVA: 0x00604AC1 File Offset: 0x00602CC1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602BBD2 RID: 179154 RVA: 0x00604ACE File Offset: 0x00602CCE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602BBD3 RID: 179155 RVA: 0x00604AD8 File Offset: 0x00602CD8
		public static IChangeElementalBoxStateTarget GetRootAsIChangeElementalBoxStateTarget(ByteBuffer _bb)
		{
			return IChangeElementalBoxStateTarget.GetRootAsIChangeElementalBoxStateTarget(_bb, default(IChangeElementalBoxStateTarget));
		}

		// Token: 0x0602BBD4 RID: 179156 RVA: 0x00604AF4 File Offset: 0x00602CF4
		public static IChangeElementalBoxStateTarget GetRootAsIChangeElementalBoxStateTarget(ByteBuffer _bb, IChangeElementalBoxStateTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602BBD5 RID: 179157 RVA: 0x00604B11 File Offset: 0x00602D11
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602BBD6 RID: 179158 RVA: 0x00604B20 File Offset: 0x00602D20
		public IChangeElementalBoxStateTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BCE1 RID: 48353
		// (get) Token: 0x0602BBD7 RID: 179159 RVA: 0x00604B30 File Offset: 0x00602D30
		public EChangeElementalBoxStateTargetType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EChangeElementalBoxStateTargetType.Player;
				}
				return (EChangeElementalBoxStateTargetType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602BBD8 RID: 179160 RVA: 0x00604B6C File Offset: 0x00602D6C
		public static Offset<IChangeElementalBoxStateTarget> CreateIChangeElementalBoxStateTarget(FlatBufferBuilder builder, EChangeElementalBoxStateTargetType Type = EChangeElementalBoxStateTargetType.Player)
		{
			builder.StartTable(1);
			IChangeElementalBoxStateTarget.AddType(builder, Type);
			return IChangeElementalBoxStateTarget.EndIChangeElementalBoxStateTarget(builder);
		}

		// Token: 0x0602BBD9 RID: 179161 RVA: 0x00604B82 File Offset: 0x00602D82
		public static void StartIChangeElementalBoxStateTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602BBDA RID: 179162 RVA: 0x00604B8B File Offset: 0x00602D8B
		public static void AddType(FlatBufferBuilder builder, EChangeElementalBoxStateTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602BBDB RID: 179163 RVA: 0x00604B96 File Offset: 0x00602D96
		public static Offset<IChangeElementalBoxStateTarget> EndIChangeElementalBoxStateTarget(FlatBufferBuilder builder)
		{
			return new Offset<IChangeElementalBoxStateTarget>(builder.EndTable());
		}

		// Token: 0x0602BBDC RID: 179164 RVA: 0x00604BA4 File Offset: 0x00602DA4
		public IChangeElementalBoxStateTargetT UnPack()
		{
			IChangeElementalBoxStateTargetT changeElementalBoxStateTargetT = new IChangeElementalBoxStateTargetT();
			this.UnPackTo(changeElementalBoxStateTargetT);
			return changeElementalBoxStateTargetT;
		}

		// Token: 0x0602BBDD RID: 179165 RVA: 0x00604BBF File Offset: 0x00602DBF
		public void UnPackTo(IChangeElementalBoxStateTargetT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602BBDE RID: 179166 RVA: 0x00604BD0 File Offset: 0x00602DD0
		public static Offset<IChangeElementalBoxStateTarget> Pack(FlatBufferBuilder builder, IChangeElementalBoxStateTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<IChangeElementalBoxStateTarget>);
			}
			return IChangeElementalBoxStateTarget.CreateIChangeElementalBoxStateTarget(builder, _o.Type);
		}

		// Token: 0x0401087F RID: 67711
		private Table __p;
	}
}
