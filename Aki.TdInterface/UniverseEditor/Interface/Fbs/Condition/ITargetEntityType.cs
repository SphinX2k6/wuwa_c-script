using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004CF1 RID: 19697
	public struct ITargetEntityType : IFlatbufferObject
	{
		// Token: 0x17008EF0 RID: 36592
		// (get) Token: 0x0601F430 RID: 128048 RVA: 0x0045CBA4 File Offset: 0x0045ADA4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F431 RID: 128049 RVA: 0x0045CBB1 File Offset: 0x0045ADB1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F432 RID: 128050 RVA: 0x0045CBB8 File Offset: 0x0045ADB8
		public static ITargetEntityType GetRootAsITargetEntityType(ByteBuffer _bb)
		{
			return ITargetEntityType.GetRootAsITargetEntityType(_bb, default(ITargetEntityType));
		}

		// Token: 0x0601F433 RID: 128051 RVA: 0x0045CBD4 File Offset: 0x0045ADD4
		public static ITargetEntityType GetRootAsITargetEntityType(ByteBuffer _bb, ITargetEntityType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F434 RID: 128052 RVA: 0x0045CBF1 File Offset: 0x0045ADF1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F435 RID: 128053 RVA: 0x0045CC00 File Offset: 0x0045AE00
		public ITargetEntityType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008EF1 RID: 36593
		// (get) Token: 0x0601F436 RID: 128054 RVA: 0x0045CC10 File Offset: 0x0045AE10
		public ETargetEntityType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETargetEntityType.Target;
				}
				return (ETargetEntityType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601F437 RID: 128055 RVA: 0x0045CC4C File Offset: 0x0045AE4C
		public static Offset<ITargetEntityType> CreateITargetEntityType(FlatBufferBuilder builder, ETargetEntityType Type = ETargetEntityType.Target)
		{
			builder.StartTable(1);
			ITargetEntityType.AddType(builder, Type);
			return ITargetEntityType.EndITargetEntityType(builder);
		}

		// Token: 0x0601F438 RID: 128056 RVA: 0x0045CC62 File Offset: 0x0045AE62
		public static void StartITargetEntityType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601F439 RID: 128057 RVA: 0x0045CC6B File Offset: 0x0045AE6B
		public static void AddType(FlatBufferBuilder builder, ETargetEntityType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F43A RID: 128058 RVA: 0x0045CC76 File Offset: 0x0045AE76
		public static Offset<ITargetEntityType> EndITargetEntityType(FlatBufferBuilder builder)
		{
			return new Offset<ITargetEntityType>(builder.EndTable());
		}

		// Token: 0x0601F43B RID: 128059 RVA: 0x0045CC84 File Offset: 0x0045AE84
		public ITargetEntityTypeT UnPack()
		{
			ITargetEntityTypeT targetEntityTypeT = new ITargetEntityTypeT();
			this.UnPackTo(targetEntityTypeT);
			return targetEntityTypeT;
		}

		// Token: 0x0601F43C RID: 128060 RVA: 0x0045CC9F File Offset: 0x0045AE9F
		public void UnPackTo(ITargetEntityTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601F43D RID: 128061 RVA: 0x0045CCB0 File Offset: 0x0045AEB0
		public static Offset<ITargetEntityType> Pack(FlatBufferBuilder builder, ITargetEntityTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITargetEntityType>);
			}
			return ITargetEntityType.CreateITargetEntityType(builder, _o.Type);
		}

		// Token: 0x0400D6C7 RID: 54983
		private Table __p;
	}
}
