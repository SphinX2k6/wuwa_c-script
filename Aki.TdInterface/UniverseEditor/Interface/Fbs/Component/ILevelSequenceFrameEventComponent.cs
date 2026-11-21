using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A74 RID: 23156
	public struct ILevelSequenceFrameEventComponent : IFlatbufferObject
	{
		// Token: 0x1700A89C RID: 43164
		// (get) Token: 0x06025EB3 RID: 155315 RVA: 0x00532CEF File Offset: 0x00530EEF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025EB4 RID: 155316 RVA: 0x00532CFC File Offset: 0x00530EFC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025EB5 RID: 155317 RVA: 0x00532D04 File Offset: 0x00530F04
		public static ILevelSequenceFrameEventComponent GetRootAsILevelSequenceFrameEventComponent(ByteBuffer _bb)
		{
			return ILevelSequenceFrameEventComponent.GetRootAsILevelSequenceFrameEventComponent(_bb, default(ILevelSequenceFrameEventComponent));
		}

		// Token: 0x06025EB6 RID: 155318 RVA: 0x00532D20 File Offset: 0x00530F20
		public static ILevelSequenceFrameEventComponent GetRootAsILevelSequenceFrameEventComponent(ByteBuffer _bb, ILevelSequenceFrameEventComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025EB7 RID: 155319 RVA: 0x00532D3D File Offset: 0x00530F3D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025EB8 RID: 155320 RVA: 0x00532D4C File Offset: 0x00530F4C
		public ILevelSequenceFrameEventComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A89D RID: 43165
		// (get) Token: 0x06025EB9 RID: 155321 RVA: 0x00532D5C File Offset: 0x00530F5C
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06025EBA RID: 155322 RVA: 0x00532D9C File Offset: 0x00530F9C
		public ILevelSequenceSectionInfo? ForwardSections(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ILevelSequenceSectionInfo?(default(ILevelSequenceSectionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A89E RID: 43166
		// (get) Token: 0x06025EBB RID: 155323 RVA: 0x00532DFC File Offset: 0x00530FFC
		public int ForwardSectionsLength
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

		// Token: 0x06025EBC RID: 155324 RVA: 0x00532E28 File Offset: 0x00531028
		public ILevelSequenceSectionInfo? BackWardSections(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new ILevelSequenceSectionInfo?(default(ILevelSequenceSectionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A89F RID: 43167
		// (get) Token: 0x06025EBD RID: 155325 RVA: 0x00532E88 File Offset: 0x00531088
		public int BackWardSectionsLength
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

		// Token: 0x1700A8A0 RID: 43168
		// (get) Token: 0x06025EBE RID: 155326 RVA: 0x00532EB4 File Offset: 0x005310B4
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06025EBF RID: 155327 RVA: 0x00532EF1 File Offset: 0x005310F1
		public static Offset<ILevelSequenceFrameEventComponent> CreateILevelSequenceFrameEventComponent(FlatBufferBuilder builder, bool Disabled = false, VectorOffset ForwardSectionsOffset = default(VectorOffset), VectorOffset BackWardSectionsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			ILevelSequenceFrameEventComponent.AddBackWardSections(builder, BackWardSectionsOffset);
			ILevelSequenceFrameEventComponent.AddForwardSections(builder, ForwardSectionsOffset);
			ILevelSequenceFrameEventComponent.AddNullMask(builder, NullMask);
			ILevelSequenceFrameEventComponent.AddDisabled(builder, Disabled);
			return ILevelSequenceFrameEventComponent.EndILevelSequenceFrameEventComponent(builder);
		}

		// Token: 0x06025EC0 RID: 155328 RVA: 0x00532F1D File Offset: 0x0053111D
		public static void StartILevelSequenceFrameEventComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06025EC1 RID: 155329 RVA: 0x00532F26 File Offset: 0x00531126
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06025EC2 RID: 155330 RVA: 0x00532F31 File Offset: 0x00531131
		public static void AddForwardSections(FlatBufferBuilder builder, VectorOffset forwardSectionsOffset)
		{
			builder.AddOffset(1, forwardSectionsOffset.Value, 0);
		}

		// Token: 0x06025EC3 RID: 155331 RVA: 0x00532F44 File Offset: 0x00531144
		public static VectorOffset CreateForwardSectionsVector(FlatBufferBuilder builder, Offset<ILevelSequenceSectionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06025EC4 RID: 155332 RVA: 0x00532F84 File Offset: 0x00531184
		public static VectorOffset CreateForwardSectionsVectorBlock(FlatBufferBuilder builder, Offset<ILevelSequenceSectionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ILevelSequenceSectionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025EC5 RID: 155333 RVA: 0x00532F9E File Offset: 0x0053119E
		public static VectorOffset CreateForwardSectionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ILevelSequenceSectionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ILevelSequenceSectionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025EC6 RID: 155334 RVA: 0x00532FBC File Offset: 0x005311BC
		public static VectorOffset CreateForwardSectionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ILevelSequenceSectionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06025EC7 RID: 155335 RVA: 0x00532FD5 File Offset: 0x005311D5
		public static void StartForwardSectionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06025EC8 RID: 155336 RVA: 0x00532FE0 File Offset: 0x005311E0
		public static void AddBackWardSections(FlatBufferBuilder builder, VectorOffset backWardSectionsOffset)
		{
			builder.AddOffset(2, backWardSectionsOffset.Value, 0);
		}

		// Token: 0x06025EC9 RID: 155337 RVA: 0x00532FF0 File Offset: 0x005311F0
		public static VectorOffset CreateBackWardSectionsVector(FlatBufferBuilder builder, Offset<ILevelSequenceSectionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06025ECA RID: 155338 RVA: 0x00533030 File Offset: 0x00531230
		public static VectorOffset CreateBackWardSectionsVectorBlock(FlatBufferBuilder builder, Offset<ILevelSequenceSectionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ILevelSequenceSectionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025ECB RID: 155339 RVA: 0x0053304A File Offset: 0x0053124A
		public static VectorOffset CreateBackWardSectionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ILevelSequenceSectionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ILevelSequenceSectionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025ECC RID: 155340 RVA: 0x00533068 File Offset: 0x00531268
		public static VectorOffset CreateBackWardSectionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ILevelSequenceSectionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06025ECD RID: 155341 RVA: 0x00533081 File Offset: 0x00531281
		public static void StartBackWardSectionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06025ECE RID: 155342 RVA: 0x0053308C File Offset: 0x0053128C
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06025ECF RID: 155343 RVA: 0x00533097 File Offset: 0x00531297
		public static Offset<ILevelSequenceFrameEventComponent> EndILevelSequenceFrameEventComponent(FlatBufferBuilder builder)
		{
			return new Offset<ILevelSequenceFrameEventComponent>(builder.EndTable());
		}

		// Token: 0x06025ED0 RID: 155344 RVA: 0x005330A4 File Offset: 0x005312A4
		public ILevelSequenceFrameEventComponentT UnPack()
		{
			ILevelSequenceFrameEventComponentT levelSequenceFrameEventComponentT = new ILevelSequenceFrameEventComponentT();
			this.UnPackTo(levelSequenceFrameEventComponentT);
			return levelSequenceFrameEventComponentT;
		}

		// Token: 0x06025ED1 RID: 155345 RVA: 0x005330C0 File Offset: 0x005312C0
		public void UnPackTo(ILevelSequenceFrameEventComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.ForwardSections = new List<ILevelSequenceSectionInfoT>();
			for (int i = 0; i < this.ForwardSectionsLength; i++)
			{
				_o.ForwardSections.Add((this.ForwardSections(i) != null) ? this.ForwardSections(i).Value.UnPack() : null);
			}
			_o.BackWardSections = new List<ILevelSequenceSectionInfoT>();
			for (int j = 0; j < this.BackWardSectionsLength; j++)
			{
				_o.BackWardSections.Add((this.BackWardSections(j) != null) ? this.BackWardSections(j).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06025ED2 RID: 155346 RVA: 0x0053318C File Offset: 0x0053138C
		public static Offset<ILevelSequenceFrameEventComponent> Pack(FlatBufferBuilder builder, ILevelSequenceFrameEventComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILevelSequenceFrameEventComponent>);
			}
			VectorOffset forwardSectionsOffset = default(VectorOffset);
			if (_o.ForwardSections != null)
			{
				Offset<ILevelSequenceSectionInfo>[] array = new Offset<ILevelSequenceSectionInfo>[_o.ForwardSections.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ILevelSequenceSectionInfo.Pack(builder, _o.ForwardSections[i]);
				}
				forwardSectionsOffset = ILevelSequenceFrameEventComponent.CreateForwardSectionsVector(builder, array);
			}
			VectorOffset backWardSectionsOffset = default(VectorOffset);
			if (_o.BackWardSections != null)
			{
				Offset<ILevelSequenceSectionInfo>[] array2 = new Offset<ILevelSequenceSectionInfo>[_o.BackWardSections.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = ILevelSequenceSectionInfo.Pack(builder, _o.BackWardSections[j]);
				}
				backWardSectionsOffset = ILevelSequenceFrameEventComponent.CreateBackWardSectionsVector(builder, array2);
			}
			return ILevelSequenceFrameEventComponent.CreateILevelSequenceFrameEventComponent(builder, _o.Disabled, forwardSectionsOffset, backWardSectionsOffset, _o.NullMask);
		}

		// Token: 0x0400F3FA RID: 62458
		private Table __p;
	}
}
