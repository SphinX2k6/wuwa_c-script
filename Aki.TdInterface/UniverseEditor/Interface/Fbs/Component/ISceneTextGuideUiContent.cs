using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058E2 RID: 22754
	public struct ISceneTextGuideUiContent : IFlatbufferObject
	{
		// Token: 0x1700AA6E RID: 43630
		// (get) Token: 0x060266B2 RID: 157362 RVA: 0x0054B579 File Offset: 0x00549779
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060266B3 RID: 157363 RVA: 0x0054B586 File Offset: 0x00549786
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060266B4 RID: 157364 RVA: 0x0054B590 File Offset: 0x00549790
		public static ISceneTextGuideUiContent GetRootAsISceneTextGuideUiContent(ByteBuffer _bb)
		{
			return ISceneTextGuideUiContent.GetRootAsISceneTextGuideUiContent(_bb, default(ISceneTextGuideUiContent));
		}

		// Token: 0x060266B5 RID: 157365 RVA: 0x0054B5AC File Offset: 0x005497AC
		public static ISceneTextGuideUiContent GetRootAsISceneTextGuideUiContent(ByteBuffer _bb, ISceneTextGuideUiContent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060266B6 RID: 157366 RVA: 0x0054B5C9 File Offset: 0x005497C9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060266B7 RID: 157367 RVA: 0x0054B5D8 File Offset: 0x005497D8
		public ISceneTextGuideUiContent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AA6F RID: 43631
		// (get) Token: 0x060266B8 RID: 157368 RVA: 0x0054B5E8 File Offset: 0x005497E8
		public string TidText
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060266B9 RID: 157369 RVA: 0x0054B61F File Offset: 0x0054981F
		public Span<byte> GetTidTextBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x060266BA RID: 157370 RVA: 0x0054B62E File Offset: 0x0054982E
		public byte[] GetTidTextArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x060266BB RID: 157371 RVA: 0x0054B63C File Offset: 0x0054983C
		public ISceneTextGuideUiActionMappingIcon? ActionMappingIconList(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ISceneTextGuideUiActionMappingIcon?(default(ISceneTextGuideUiActionMappingIcon).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700AA70 RID: 43632
		// (get) Token: 0x060266BC RID: 157372 RVA: 0x0054B69C File Offset: 0x0054989C
		public int ActionMappingIconListLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060266BD RID: 157373 RVA: 0x0054B6C8 File Offset: 0x005498C8
		public string MobileIconList(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700AA71 RID: 43633
		// (get) Token: 0x060266BE RID: 157374 RVA: 0x0054B704 File Offset: 0x00549904
		public int MobileIconListLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060266BF RID: 157375 RVA: 0x0054B72F File Offset: 0x0054992F
		public static Offset<ISceneTextGuideUiContent> CreateISceneTextGuideUiContent(FlatBufferBuilder builder, StringOffset TidTextOffset = default(StringOffset), VectorOffset ActionMappingIconListOffset = default(VectorOffset), VectorOffset MobileIconListOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			ISceneTextGuideUiContent.AddMobileIconList(builder, MobileIconListOffset);
			ISceneTextGuideUiContent.AddActionMappingIconList(builder, ActionMappingIconListOffset);
			ISceneTextGuideUiContent.AddTidText(builder, TidTextOffset);
			return ISceneTextGuideUiContent.EndISceneTextGuideUiContent(builder);
		}

		// Token: 0x060266C0 RID: 157376 RVA: 0x0054B753 File Offset: 0x00549953
		public static void StartISceneTextGuideUiContent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060266C1 RID: 157377 RVA: 0x0054B75C File Offset: 0x0054995C
		public static void AddTidText(FlatBufferBuilder builder, StringOffset tidTextOffset)
		{
			builder.AddOffset(0, tidTextOffset.Value, 0);
		}

		// Token: 0x060266C2 RID: 157378 RVA: 0x0054B76C File Offset: 0x0054996C
		public static void AddActionMappingIconList(FlatBufferBuilder builder, VectorOffset actionMappingIconListOffset)
		{
			builder.AddOffset(1, actionMappingIconListOffset.Value, 0);
		}

		// Token: 0x060266C3 RID: 157379 RVA: 0x0054B77C File Offset: 0x0054997C
		public static VectorOffset CreateActionMappingIconListVector(FlatBufferBuilder builder, Offset<ISceneTextGuideUiActionMappingIcon>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060266C4 RID: 157380 RVA: 0x0054B7BC File Offset: 0x005499BC
		public static VectorOffset CreateActionMappingIconListVectorBlock(FlatBufferBuilder builder, Offset<ISceneTextGuideUiActionMappingIcon>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ISceneTextGuideUiActionMappingIcon>>(data);
			return builder.EndVector();
		}

		// Token: 0x060266C5 RID: 157381 RVA: 0x0054B7D6 File Offset: 0x005499D6
		public static VectorOffset CreateActionMappingIconListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ISceneTextGuideUiActionMappingIcon>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ISceneTextGuideUiActionMappingIcon>>(data);
			return builder.EndVector();
		}

		// Token: 0x060266C6 RID: 157382 RVA: 0x0054B7F4 File Offset: 0x005499F4
		public static VectorOffset CreateActionMappingIconListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ISceneTextGuideUiActionMappingIcon>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060266C7 RID: 157383 RVA: 0x0054B80D File Offset: 0x00549A0D
		public static void StartActionMappingIconListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060266C8 RID: 157384 RVA: 0x0054B818 File Offset: 0x00549A18
		public static void AddMobileIconList(FlatBufferBuilder builder, VectorOffset mobileIconListOffset)
		{
			builder.AddOffset(2, mobileIconListOffset.Value, 0);
		}

		// Token: 0x060266C9 RID: 157385 RVA: 0x0054B828 File Offset: 0x00549A28
		public static VectorOffset CreateMobileIconListVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060266CA RID: 157386 RVA: 0x0054B868 File Offset: 0x00549A68
		public static VectorOffset CreateMobileIconListVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x060266CB RID: 157387 RVA: 0x0054B882 File Offset: 0x00549A82
		public static VectorOffset CreateMobileIconListVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x060266CC RID: 157388 RVA: 0x0054B8A0 File Offset: 0x00549AA0
		public static VectorOffset CreateMobileIconListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060266CD RID: 157389 RVA: 0x0054B8B9 File Offset: 0x00549AB9
		public static void StartMobileIconListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060266CE RID: 157390 RVA: 0x0054B8C4 File Offset: 0x00549AC4
		public static Offset<ISceneTextGuideUiContent> EndISceneTextGuideUiContent(FlatBufferBuilder builder)
		{
			return new Offset<ISceneTextGuideUiContent>(builder.EndTable());
		}

		// Token: 0x060266CF RID: 157391 RVA: 0x0054B8D4 File Offset: 0x00549AD4
		public ISceneTextGuideUiContentT UnPack()
		{
			ISceneTextGuideUiContentT sceneTextGuideUiContentT = new ISceneTextGuideUiContentT();
			this.UnPackTo(sceneTextGuideUiContentT);
			return sceneTextGuideUiContentT;
		}

		// Token: 0x060266D0 RID: 157392 RVA: 0x0054B8F0 File Offset: 0x00549AF0
		public void UnPackTo(ISceneTextGuideUiContentT _o)
		{
			_o.TidText = this.TidText;
			_o.ActionMappingIconList = new List<ISceneTextGuideUiActionMappingIconT>();
			for (int i = 0; i < this.ActionMappingIconListLength; i++)
			{
				_o.ActionMappingIconList.Add((this.ActionMappingIconList(i) != null) ? this.ActionMappingIconList(i).Value.UnPack() : null);
			}
			_o.MobileIconList = new List<string>();
			for (int j = 0; j < this.MobileIconListLength; j++)
			{
				_o.MobileIconList.Add(this.MobileIconList(j));
			}
		}

		// Token: 0x060266D1 RID: 157393 RVA: 0x0054B98C File Offset: 0x00549B8C
		public static Offset<ISceneTextGuideUiContent> Pack(FlatBufferBuilder builder, ISceneTextGuideUiContentT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISceneTextGuideUiContent>);
			}
			StringOffset tidTextOffset = (_o.TidText == null) ? default(StringOffset) : builder.CreateString(_o.TidText);
			VectorOffset actionMappingIconListOffset = default(VectorOffset);
			if (_o.ActionMappingIconList != null)
			{
				Offset<ISceneTextGuideUiActionMappingIcon>[] array = new Offset<ISceneTextGuideUiActionMappingIcon>[_o.ActionMappingIconList.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ISceneTextGuideUiActionMappingIcon.Pack(builder, _o.ActionMappingIconList[i]);
				}
				actionMappingIconListOffset = ISceneTextGuideUiContent.CreateActionMappingIconListVector(builder, array);
			}
			VectorOffset mobileIconListOffset = default(VectorOffset);
			if (_o.MobileIconList != null)
			{
				StringOffset[] array2 = new StringOffset[_o.MobileIconList.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = builder.CreateString(_o.MobileIconList[j]);
				}
				mobileIconListOffset = ISceneTextGuideUiContent.CreateMobileIconListVector(builder, array2);
			}
			return ISceneTextGuideUiContent.CreateISceneTextGuideUiContent(builder, tidTextOffset, actionMappingIconListOffset, mobileIconListOffset);
		}

		// Token: 0x0400EE69 RID: 61033
		private Table __p;
	}
}
