using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007550 RID: 30032
	public struct IVisualNovelActivityActionConfigBase : IFlatbufferObject
	{
		// Token: 0x1700E3DC RID: 58332
		// (get) Token: 0x06036A46 RID: 223814 RVA: 0x0076C19D File Offset: 0x0076A39D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036A47 RID: 223815 RVA: 0x0076C1AA File Offset: 0x0076A3AA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036A48 RID: 223816 RVA: 0x0076C1B4 File Offset: 0x0076A3B4
		public static IVisualNovelActivityActionConfigBase GetRootAsIVisualNovelActivityActionConfigBase(ByteBuffer _bb)
		{
			return IVisualNovelActivityActionConfigBase.GetRootAsIVisualNovelActivityActionConfigBase(_bb, default(IVisualNovelActivityActionConfigBase));
		}

		// Token: 0x06036A49 RID: 223817 RVA: 0x0076C1D0 File Offset: 0x0076A3D0
		public static IVisualNovelActivityActionConfigBase GetRootAsIVisualNovelActivityActionConfigBase(ByteBuffer _bb, IVisualNovelActivityActionConfigBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036A4A RID: 223818 RVA: 0x0076C1ED File Offset: 0x0076A3ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036A4B RID: 223819 RVA: 0x0076C1FC File Offset: 0x0076A3FC
		public IVisualNovelActivityActionConfigBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E3DD RID: 58333
		// (get) Token: 0x06036A4C RID: 223820 RVA: 0x0076C20C File Offset: 0x0076A40C
		public EVisualNovelSubType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EVisualNovelSubType.SolarSchool;
				}
				return (EVisualNovelSubType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06036A4D RID: 223821 RVA: 0x0076C248 File Offset: 0x0076A448
		public static Offset<IVisualNovelActivityActionConfigBase> CreateIVisualNovelActivityActionConfigBase(FlatBufferBuilder builder, EVisualNovelSubType Type = EVisualNovelSubType.SolarSchool)
		{
			builder.StartTable(1);
			IVisualNovelActivityActionConfigBase.AddType(builder, Type);
			return IVisualNovelActivityActionConfigBase.EndIVisualNovelActivityActionConfigBase(builder);
		}

		// Token: 0x06036A4E RID: 223822 RVA: 0x0076C25E File Offset: 0x0076A45E
		public static void StartIVisualNovelActivityActionConfigBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06036A4F RID: 223823 RVA: 0x0076C267 File Offset: 0x0076A467
		public static void AddType(FlatBufferBuilder builder, EVisualNovelSubType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036A50 RID: 223824 RVA: 0x0076C272 File Offset: 0x0076A472
		public static Offset<IVisualNovelActivityActionConfigBase> EndIVisualNovelActivityActionConfigBase(FlatBufferBuilder builder)
		{
			return new Offset<IVisualNovelActivityActionConfigBase>(builder.EndTable());
		}

		// Token: 0x06036A51 RID: 223825 RVA: 0x0076C280 File Offset: 0x0076A480
		public IVisualNovelActivityActionConfigBaseT UnPack()
		{
			IVisualNovelActivityActionConfigBaseT visualNovelActivityActionConfigBaseT = new IVisualNovelActivityActionConfigBaseT();
			this.UnPackTo(visualNovelActivityActionConfigBaseT);
			return visualNovelActivityActionConfigBaseT;
		}

		// Token: 0x06036A52 RID: 223826 RVA: 0x0076C29B File Offset: 0x0076A49B
		public void UnPackTo(IVisualNovelActivityActionConfigBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06036A53 RID: 223827 RVA: 0x0076C2AC File Offset: 0x0076A4AC
		public static Offset<IVisualNovelActivityActionConfigBase> Pack(FlatBufferBuilder builder, IVisualNovelActivityActionConfigBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisualNovelActivityActionConfigBase>);
			}
			return IVisualNovelActivityActionConfigBase.CreateIVisualNovelActivityActionConfigBase(builder, _o.Type);
		}

		// Token: 0x04012448 RID: 74824
		private Table __p;
	}
}
