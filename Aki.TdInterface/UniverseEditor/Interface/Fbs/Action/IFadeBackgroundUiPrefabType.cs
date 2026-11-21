using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E0C RID: 28172
	public struct IFadeBackgroundUiPrefabType : IFlatbufferObject
	{
		// Token: 0x1700CE77 RID: 52855
		// (get) Token: 0x06030A31 RID: 199217 RVA: 0x0069A36C File Offset: 0x0069856C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030A32 RID: 199218 RVA: 0x0069A379 File Offset: 0x00698579
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030A33 RID: 199219 RVA: 0x0069A380 File Offset: 0x00698580
		public static IFadeBackgroundUiPrefabType GetRootAsIFadeBackgroundUiPrefabType(ByteBuffer _bb)
		{
			return IFadeBackgroundUiPrefabType.GetRootAsIFadeBackgroundUiPrefabType(_bb, default(IFadeBackgroundUiPrefabType));
		}

		// Token: 0x06030A34 RID: 199220 RVA: 0x0069A39C File Offset: 0x0069859C
		public static IFadeBackgroundUiPrefabType GetRootAsIFadeBackgroundUiPrefabType(ByteBuffer _bb, IFadeBackgroundUiPrefabType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030A35 RID: 199221 RVA: 0x0069A3B9 File Offset: 0x006985B9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030A36 RID: 199222 RVA: 0x0069A3C8 File Offset: 0x006985C8
		public IFadeBackgroundUiPrefabType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CE78 RID: 52856
		// (get) Token: 0x06030A37 RID: 199223 RVA: 0x0069A3D8 File Offset: 0x006985D8
		public EFadeBackgroundUiPrefabType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EFadeBackgroundUiPrefabType.BlackScreenWhiteText;
				}
				return (EFadeBackgroundUiPrefabType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06030A38 RID: 199224 RVA: 0x0069A414 File Offset: 0x00698614
		public static Offset<IFadeBackgroundUiPrefabType> CreateIFadeBackgroundUiPrefabType(FlatBufferBuilder builder, EFadeBackgroundUiPrefabType Type = EFadeBackgroundUiPrefabType.BlackScreenWhiteText)
		{
			builder.StartTable(1);
			IFadeBackgroundUiPrefabType.AddType(builder, Type);
			return IFadeBackgroundUiPrefabType.EndIFadeBackgroundUiPrefabType(builder);
		}

		// Token: 0x06030A39 RID: 199225 RVA: 0x0069A42A File Offset: 0x0069862A
		public static void StartIFadeBackgroundUiPrefabType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06030A3A RID: 199226 RVA: 0x0069A433 File Offset: 0x00698633
		public static void AddType(FlatBufferBuilder builder, EFadeBackgroundUiPrefabType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06030A3B RID: 199227 RVA: 0x0069A43E File Offset: 0x0069863E
		public static Offset<IFadeBackgroundUiPrefabType> EndIFadeBackgroundUiPrefabType(FlatBufferBuilder builder)
		{
			return new Offset<IFadeBackgroundUiPrefabType>(builder.EndTable());
		}

		// Token: 0x06030A3C RID: 199228 RVA: 0x0069A44C File Offset: 0x0069864C
		public IFadeBackgroundUiPrefabTypeT UnPack()
		{
			IFadeBackgroundUiPrefabTypeT fadeBackgroundUiPrefabTypeT = new IFadeBackgroundUiPrefabTypeT();
			this.UnPackTo(fadeBackgroundUiPrefabTypeT);
			return fadeBackgroundUiPrefabTypeT;
		}

		// Token: 0x06030A3D RID: 199229 RVA: 0x0069A467 File Offset: 0x00698667
		public void UnPackTo(IFadeBackgroundUiPrefabTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06030A3E RID: 199230 RVA: 0x0069A478 File Offset: 0x00698678
		public static Offset<IFadeBackgroundUiPrefabType> Pack(FlatBufferBuilder builder, IFadeBackgroundUiPrefabTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFadeBackgroundUiPrefabType>);
			}
			return IFadeBackgroundUiPrefabType.CreateIFadeBackgroundUiPrefabType(builder, _o.Type);
		}

		// Token: 0x04011CC4 RID: 72900
		private Table __p;
	}
}
