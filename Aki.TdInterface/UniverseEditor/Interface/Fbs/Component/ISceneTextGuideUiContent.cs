using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005EEF RID: 24303
	public struct ISceneTextGuideUiContent : IFlatbufferObject
	{
		// Token: 0x1700B39E RID: 45982
		// (get) Token: 0x06028C14 RID: 166932 RVA: 0x005920C5 File Offset: 0x005902C5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028C15 RID: 166933 RVA: 0x005920D2 File Offset: 0x005902D2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028C16 RID: 166934 RVA: 0x005920DC File Offset: 0x005902DC
		public static ISceneTextGuideUiContent GetRootAsISceneTextGuideUiContent(ByteBuffer _bb)
		{
			return ISceneTextGuideUiContent.GetRootAsISceneTextGuideUiContent(_bb, default(ISceneTextGuideUiContent));
		}

		// Token: 0x06028C17 RID: 166935 RVA: 0x005920F8 File Offset: 0x005902F8
		public static ISceneTextGuideUiContent GetRootAsISceneTextGuideUiContent(ByteBuffer _bb, ISceneTextGuideUiContent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028C18 RID: 166936 RVA: 0x00592115 File Offset: 0x00590315
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028C19 RID: 166937 RVA: 0x00592124 File Offset: 0x00590324
		public ISceneTextGuideUiContent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B39F RID: 45983
		// (get) Token: 0x06028C1A RID: 166938 RVA: 0x00592134 File Offset: 0x00590334
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

		// Token: 0x06028C1B RID: 166939 RVA: 0x0059216B File Offset: 0x0059036B
		public Span<byte> GetTidTextBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06028C1C RID: 166940 RVA: 0x0059217A File Offset: 0x0059037A
		public byte[] GetTidTextArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x06028C1D RID: 166941 RVA: 0x00592188 File Offset: 0x00590388
		public ISceneTextGuideUiActionMappingIcon? ActionMappingIconList(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ISceneTextGuideUiActionMappingIcon?(default(ISceneTextGuideUiActionMappingIcon).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B3A0 RID: 45984
		// (get) Token: 0x06028C1E RID: 166942 RVA: 0x005921E8 File Offset: 0x005903E8
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

		// Token: 0x06028C1F RID: 166943 RVA: 0x00592214 File Offset: 0x00590414
		public string MobileIconList(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700B3A1 RID: 45985
		// (get) Token: 0x06028C20 RID: 166944 RVA: 0x00592250 File Offset: 0x00590450
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

		// Token: 0x06028C21 RID: 166945 RVA: 0x0059227B File Offset: 0x0059047B
		public static Offset<ISceneTextGuideUiContent> CreateISceneTextGuideUiContent(FlatBufferBuilder builder, StringOffset TidTextOffset = default(StringOffset), VectorOffset ActionMappingIconListOffset = default(VectorOffset), VectorOffset MobileIconListOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			ISceneTextGuideUiContent.AddMobileIconList(builder, MobileIconListOffset);
			ISceneTextGuideUiContent.AddActionMappingIconList(builder, ActionMappingIconListOffset);
			ISceneTextGuideUiContent.AddTidText(builder, TidTextOffset);
			return ISceneTextGuideUiContent.EndISceneTextGuideUiContent(builder);
		}

		// Token: 0x06028C22 RID: 166946 RVA: 0x0059229F File Offset: 0x0059049F
		public static void StartISceneTextGuideUiContent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06028C23 RID: 166947 RVA: 0x005922A8 File Offset: 0x005904A8
		public static void AddTidText(FlatBufferBuilder builder, StringOffset tidTextOffset)
		{
			builder.AddOffset(0, tidTextOffset.Value, 0);
		}

		// Token: 0x06028C24 RID: 166948 RVA: 0x005922B8 File Offset: 0x005904B8
		public static void AddActionMappingIconList(FlatBufferBuilder builder, VectorOffset actionMappingIconListOffset)
		{
			builder.AddOffset(1, actionMappingIconListOffset.Value, 0);
		}

		// Token: 0x06028C25 RID: 166949 RVA: 0x005922C8 File Offset: 0x005904C8
		public static VectorOffset CreateActionMappingIconListVector(FlatBufferBuilder builder, Offset<ISceneTextGuideUiActionMappingIcon>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06028C26 RID: 166950 RVA: 0x00592308 File Offset: 0x00590508
		public static VectorOffset CreateActionMappingIconListVectorBlock(FlatBufferBuilder builder, Offset<ISceneTextGuideUiActionMappingIcon>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ISceneTextGuideUiActionMappingIcon>>(data);
			return builder.EndVector();
		}

		// Token: 0x06028C27 RID: 166951 RVA: 0x00592322 File Offset: 0x00590522
		public static VectorOffset CreateActionMappingIconListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ISceneTextGuideUiActionMappingIcon>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ISceneTextGuideUiActionMappingIcon>>(data);
			return builder.EndVector();
		}

		// Token: 0x06028C28 RID: 166952 RVA: 0x00592340 File Offset: 0x00590540
		public static VectorOffset CreateActionMappingIconListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ISceneTextGuideUiActionMappingIcon>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06028C29 RID: 166953 RVA: 0x00592359 File Offset: 0x00590559
		public static void StartActionMappingIconListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06028C2A RID: 166954 RVA: 0x00592364 File Offset: 0x00590564
		public static void AddMobileIconList(FlatBufferBuilder builder, VectorOffset mobileIconListOffset)
		{
			builder.AddOffset(2, mobileIconListOffset.Value, 0);
		}

		// Token: 0x06028C2B RID: 166955 RVA: 0x00592374 File Offset: 0x00590574
		public static VectorOffset CreateMobileIconListVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06028C2C RID: 166956 RVA: 0x005923B4 File Offset: 0x005905B4
		public static VectorOffset CreateMobileIconListVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06028C2D RID: 166957 RVA: 0x005923CE File Offset: 0x005905CE
		public static VectorOffset CreateMobileIconListVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06028C2E RID: 166958 RVA: 0x005923EC File Offset: 0x005905EC
		public static VectorOffset CreateMobileIconListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06028C2F RID: 166959 RVA: 0x00592405 File Offset: 0x00590605
		public static void StartMobileIconListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06028C30 RID: 166960 RVA: 0x00592410 File Offset: 0x00590610
		public static Offset<ISceneTextGuideUiContent> EndISceneTextGuideUiContent(FlatBufferBuilder builder)
		{
			return new Offset<ISceneTextGuideUiContent>(builder.EndTable());
		}

		// Token: 0x06028C31 RID: 166961 RVA: 0x00592420 File Offset: 0x00590620
		public ISceneTextGuideUiContentT UnPack()
		{
			ISceneTextGuideUiContentT sceneTextGuideUiContentT = new ISceneTextGuideUiContentT();
			this.UnPackTo(sceneTextGuideUiContentT);
			return sceneTextGuideUiContentT;
		}

		// Token: 0x06028C32 RID: 166962 RVA: 0x0059243C File Offset: 0x0059063C
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

		// Token: 0x06028C33 RID: 166963 RVA: 0x005924D8 File Offset: 0x005906D8
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

		// Token: 0x0400FB5C RID: 64348
		private Table __p;
	}
}
