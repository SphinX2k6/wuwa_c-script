using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B51 RID: 27473
	public struct ICreatePrefabConfig : IFlatbufferObject
	{
		// Token: 0x1700C9B8 RID: 51640
		// (get) Token: 0x0602F473 RID: 193651 RVA: 0x00674690 File Offset: 0x00672890
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F474 RID: 193652 RVA: 0x0067469D File Offset: 0x0067289D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F475 RID: 193653 RVA: 0x006746A4 File Offset: 0x006728A4
		public static ICreatePrefabConfig GetRootAsICreatePrefabConfig(ByteBuffer _bb)
		{
			return ICreatePrefabConfig.GetRootAsICreatePrefabConfig(_bb, default(ICreatePrefabConfig));
		}

		// Token: 0x0602F476 RID: 193654 RVA: 0x006746C0 File Offset: 0x006728C0
		public static ICreatePrefabConfig GetRootAsICreatePrefabConfig(ByteBuffer _bb, ICreatePrefabConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F477 RID: 193655 RVA: 0x006746DD File Offset: 0x006728DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F478 RID: 193656 RVA: 0x006746EC File Offset: 0x006728EC
		public ICreatePrefabConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C9B9 RID: 51641
		// (get) Token: 0x0602F479 RID: 193657 RVA: 0x006746FC File Offset: 0x006728FC
		public ECreatePrefabType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECreatePrefabType.PrefabId;
				}
				return (ECreatePrefabType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602F47A RID: 193658 RVA: 0x00674738 File Offset: 0x00672938
		public static Offset<ICreatePrefabConfig> CreateICreatePrefabConfig(FlatBufferBuilder builder, ECreatePrefabType Type = ECreatePrefabType.PrefabId)
		{
			builder.StartTable(1);
			ICreatePrefabConfig.AddType(builder, Type);
			return ICreatePrefabConfig.EndICreatePrefabConfig(builder);
		}

		// Token: 0x0602F47B RID: 193659 RVA: 0x0067474E File Offset: 0x0067294E
		public static void StartICreatePrefabConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602F47C RID: 193660 RVA: 0x00674757 File Offset: 0x00672957
		public static void AddType(FlatBufferBuilder builder, ECreatePrefabType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602F47D RID: 193661 RVA: 0x00674762 File Offset: 0x00672962
		public static Offset<ICreatePrefabConfig> EndICreatePrefabConfig(FlatBufferBuilder builder)
		{
			return new Offset<ICreatePrefabConfig>(builder.EndTable());
		}

		// Token: 0x0602F47E RID: 193662 RVA: 0x00674770 File Offset: 0x00672970
		public ICreatePrefabConfigT UnPack()
		{
			ICreatePrefabConfigT createPrefabConfigT = new ICreatePrefabConfigT();
			this.UnPackTo(createPrefabConfigT);
			return createPrefabConfigT;
		}

		// Token: 0x0602F47F RID: 193663 RVA: 0x0067478B File Offset: 0x0067298B
		public void UnPackTo(ICreatePrefabConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602F480 RID: 193664 RVA: 0x0067479C File Offset: 0x0067299C
		public static Offset<ICreatePrefabConfig> Pack(FlatBufferBuilder builder, ICreatePrefabConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICreatePrefabConfig>);
			}
			return ICreatePrefabConfig.CreateICreatePrefabConfig(builder, _o.Type);
		}

		// Token: 0x0401193A RID: 71994
		private Table __p;
	}
}
