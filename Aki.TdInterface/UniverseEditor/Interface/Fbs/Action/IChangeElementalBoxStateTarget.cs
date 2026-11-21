using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006949 RID: 26953
	public struct IChangeElementalBoxStateTarget : IFlatbufferObject
	{
		// Token: 0x1700C66A RID: 50794
		// (get) Token: 0x0602E33A RID: 189242 RVA: 0x0064FACD File Offset: 0x0064DCCD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E33B RID: 189243 RVA: 0x0064FADA File Offset: 0x0064DCDA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E33C RID: 189244 RVA: 0x0064FAE4 File Offset: 0x0064DCE4
		public static IChangeElementalBoxStateTarget GetRootAsIChangeElementalBoxStateTarget(ByteBuffer _bb)
		{
			return IChangeElementalBoxStateTarget.GetRootAsIChangeElementalBoxStateTarget(_bb, default(IChangeElementalBoxStateTarget));
		}

		// Token: 0x0602E33D RID: 189245 RVA: 0x0064FB00 File Offset: 0x0064DD00
		public static IChangeElementalBoxStateTarget GetRootAsIChangeElementalBoxStateTarget(ByteBuffer _bb, IChangeElementalBoxStateTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E33E RID: 189246 RVA: 0x0064FB1D File Offset: 0x0064DD1D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E33F RID: 189247 RVA: 0x0064FB2C File Offset: 0x0064DD2C
		public IChangeElementalBoxStateTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C66B RID: 50795
		// (get) Token: 0x0602E340 RID: 189248 RVA: 0x0064FB3C File Offset: 0x0064DD3C
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

		// Token: 0x0602E341 RID: 189249 RVA: 0x0064FB78 File Offset: 0x0064DD78
		public static Offset<IChangeElementalBoxStateTarget> CreateIChangeElementalBoxStateTarget(FlatBufferBuilder builder, EChangeElementalBoxStateTargetType Type = EChangeElementalBoxStateTargetType.Player)
		{
			builder.StartTable(1);
			IChangeElementalBoxStateTarget.AddType(builder, Type);
			return IChangeElementalBoxStateTarget.EndIChangeElementalBoxStateTarget(builder);
		}

		// Token: 0x0602E342 RID: 189250 RVA: 0x0064FB8E File Offset: 0x0064DD8E
		public static void StartIChangeElementalBoxStateTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602E343 RID: 189251 RVA: 0x0064FB97 File Offset: 0x0064DD97
		public static void AddType(FlatBufferBuilder builder, EChangeElementalBoxStateTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602E344 RID: 189252 RVA: 0x0064FBA2 File Offset: 0x0064DDA2
		public static Offset<IChangeElementalBoxStateTarget> EndIChangeElementalBoxStateTarget(FlatBufferBuilder builder)
		{
			return new Offset<IChangeElementalBoxStateTarget>(builder.EndTable());
		}

		// Token: 0x0602E345 RID: 189253 RVA: 0x0064FBB0 File Offset: 0x0064DDB0
		public IChangeElementalBoxStateTargetT UnPack()
		{
			IChangeElementalBoxStateTargetT changeElementalBoxStateTargetT = new IChangeElementalBoxStateTargetT();
			this.UnPackTo(changeElementalBoxStateTargetT);
			return changeElementalBoxStateTargetT;
		}

		// Token: 0x0602E346 RID: 189254 RVA: 0x0064FBCB File Offset: 0x0064DDCB
		public void UnPackTo(IChangeElementalBoxStateTargetT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602E347 RID: 189255 RVA: 0x0064FBDC File Offset: 0x0064DDDC
		public static Offset<IChangeElementalBoxStateTarget> Pack(FlatBufferBuilder builder, IChangeElementalBoxStateTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<IChangeElementalBoxStateTarget>);
			}
			return IChangeElementalBoxStateTarget.CreateIChangeElementalBoxStateTarget(builder, _o.Type);
		}

		// Token: 0x04011695 RID: 71317
		private Table __p;
	}
}
