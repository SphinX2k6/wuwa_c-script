using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076D8 RID: 30424
	public struct ISceneUiSubtitleLocalizationConfig : IFlatbufferObject
	{
		// Token: 0x1700DF31 RID: 57137
		// (get) Token: 0x06035615 RID: 218645 RVA: 0x00728F40 File Offset: 0x00727140
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035616 RID: 218646 RVA: 0x00728F4D File Offset: 0x0072714D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035617 RID: 218647 RVA: 0x00728F54 File Offset: 0x00727154
		public static ISceneUiSubtitleLocalizationConfig GetRootAsISceneUiSubtitleLocalizationConfig(ByteBuffer _bb)
		{
			return ISceneUiSubtitleLocalizationConfig.GetRootAsISceneUiSubtitleLocalizationConfig(_bb, default(ISceneUiSubtitleLocalizationConfig));
		}

		// Token: 0x06035618 RID: 218648 RVA: 0x00728F70 File Offset: 0x00727170
		public static ISceneUiSubtitleLocalizationConfig GetRootAsISceneUiSubtitleLocalizationConfig(ByteBuffer _bb, ISceneUiSubtitleLocalizationConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035619 RID: 218649 RVA: 0x00728F8D File Offset: 0x0072718D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603561A RID: 218650 RVA: 0x00728F9C File Offset: 0x0072719C
		public ISceneUiSubtitleLocalizationConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0603561B RID: 218651 RVA: 0x00728FAC File Offset: 0x007271AC
		public ISceneUiSubtitleLanguageOverride? OverrideList(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new ISceneUiSubtitleLanguageOverride?(default(ISceneUiSubtitleLanguageOverride).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700DF32 RID: 57138
		// (get) Token: 0x0603561C RID: 218652 RVA: 0x0072900C File Offset: 0x0072720C
		public int OverrideListLength
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0603561D RID: 218653 RVA: 0x00729037 File Offset: 0x00727237
		public static Offset<ISceneUiSubtitleLocalizationConfig> CreateISceneUiSubtitleLocalizationConfig(FlatBufferBuilder builder, VectorOffset OverrideListOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			ISceneUiSubtitleLocalizationConfig.AddOverrideList(builder, OverrideListOffset);
			return ISceneUiSubtitleLocalizationConfig.EndISceneUiSubtitleLocalizationConfig(builder);
		}

		// Token: 0x0603561E RID: 218654 RVA: 0x0072904D File Offset: 0x0072724D
		public static void StartISceneUiSubtitleLocalizationConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0603561F RID: 218655 RVA: 0x00729056 File Offset: 0x00727256
		public static void AddOverrideList(FlatBufferBuilder builder, VectorOffset overrideListOffset)
		{
			builder.AddOffset(0, overrideListOffset.Value, 0);
		}

		// Token: 0x06035620 RID: 218656 RVA: 0x00729068 File Offset: 0x00727268
		public static VectorOffset CreateOverrideListVector(FlatBufferBuilder builder, Offset<ISceneUiSubtitleLanguageOverride>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06035621 RID: 218657 RVA: 0x007290A8 File Offset: 0x007272A8
		public static VectorOffset CreateOverrideListVectorBlock(FlatBufferBuilder builder, Offset<ISceneUiSubtitleLanguageOverride>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ISceneUiSubtitleLanguageOverride>>(data);
			return builder.EndVector();
		}

		// Token: 0x06035622 RID: 218658 RVA: 0x007290C2 File Offset: 0x007272C2
		public static VectorOffset CreateOverrideListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ISceneUiSubtitleLanguageOverride>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ISceneUiSubtitleLanguageOverride>>(data);
			return builder.EndVector();
		}

		// Token: 0x06035623 RID: 218659 RVA: 0x007290E0 File Offset: 0x007272E0
		public static VectorOffset CreateOverrideListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ISceneUiSubtitleLanguageOverride>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06035624 RID: 218660 RVA: 0x007290F9 File Offset: 0x007272F9
		public static void StartOverrideListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06035625 RID: 218661 RVA: 0x00729104 File Offset: 0x00727304
		public static Offset<ISceneUiSubtitleLocalizationConfig> EndISceneUiSubtitleLocalizationConfig(FlatBufferBuilder builder)
		{
			return new Offset<ISceneUiSubtitleLocalizationConfig>(builder.EndTable());
		}

		// Token: 0x06035626 RID: 218662 RVA: 0x00729114 File Offset: 0x00727314
		public ISceneUiSubtitleLocalizationConfigT UnPack()
		{
			ISceneUiSubtitleLocalizationConfigT sceneUiSubtitleLocalizationConfigT = new ISceneUiSubtitleLocalizationConfigT();
			this.UnPackTo(sceneUiSubtitleLocalizationConfigT);
			return sceneUiSubtitleLocalizationConfigT;
		}

		// Token: 0x06035627 RID: 218663 RVA: 0x00729130 File Offset: 0x00727330
		public void UnPackTo(ISceneUiSubtitleLocalizationConfigT _o)
		{
			_o.OverrideList = new List<ISceneUiSubtitleLanguageOverrideT>();
			for (int i = 0; i < this.OverrideListLength; i++)
			{
				_o.OverrideList.Add((this.OverrideList(i) != null) ? this.OverrideList(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06035628 RID: 218664 RVA: 0x00729190 File Offset: 0x00727390
		public static Offset<ISceneUiSubtitleLocalizationConfig> Pack(FlatBufferBuilder builder, ISceneUiSubtitleLocalizationConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISceneUiSubtitleLocalizationConfig>);
			}
			VectorOffset overrideListOffset = default(VectorOffset);
			if (_o.OverrideList != null)
			{
				Offset<ISceneUiSubtitleLanguageOverride>[] array = new Offset<ISceneUiSubtitleLanguageOverride>[_o.OverrideList.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ISceneUiSubtitleLanguageOverride.Pack(builder, _o.OverrideList[i]);
				}
				overrideListOffset = ISceneUiSubtitleLocalizationConfig.CreateOverrideListVector(builder, array);
			}
			return ISceneUiSubtitleLocalizationConfig.CreateISceneUiSubtitleLocalizationConfig(builder, overrideListOffset);
		}

		// Token: 0x040128D9 RID: 75993
		private Table __p;
	}
}
