using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054EE RID: 21742
	public struct ILevelSequenceFrameEventComponent : IFlatbufferObject
	{
		// Token: 0x1700A062 RID: 41058
		// (get) Token: 0x06023DF9 RID: 146937 RVA: 0x004F5BCB File Offset: 0x004F3DCB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023DFA RID: 146938 RVA: 0x004F5BD8 File Offset: 0x004F3DD8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023DFB RID: 146939 RVA: 0x004F5BE0 File Offset: 0x004F3DE0
		public static ILevelSequenceFrameEventComponent GetRootAsILevelSequenceFrameEventComponent(ByteBuffer _bb)
		{
			return ILevelSequenceFrameEventComponent.GetRootAsILevelSequenceFrameEventComponent(_bb, default(ILevelSequenceFrameEventComponent));
		}

		// Token: 0x06023DFC RID: 146940 RVA: 0x004F5BFC File Offset: 0x004F3DFC
		public static ILevelSequenceFrameEventComponent GetRootAsILevelSequenceFrameEventComponent(ByteBuffer _bb, ILevelSequenceFrameEventComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023DFD RID: 146941 RVA: 0x004F5C19 File Offset: 0x004F3E19
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023DFE RID: 146942 RVA: 0x004F5C28 File Offset: 0x004F3E28
		public ILevelSequenceFrameEventComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A063 RID: 41059
		// (get) Token: 0x06023DFF RID: 146943 RVA: 0x004F5C38 File Offset: 0x004F3E38
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06023E00 RID: 146944 RVA: 0x004F5C78 File Offset: 0x004F3E78
		public ILevelSequenceSectionInfo? ForwardSections(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ILevelSequenceSectionInfo?(default(ILevelSequenceSectionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A064 RID: 41060
		// (get) Token: 0x06023E01 RID: 146945 RVA: 0x004F5CD8 File Offset: 0x004F3ED8
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

		// Token: 0x06023E02 RID: 146946 RVA: 0x004F5D04 File Offset: 0x004F3F04
		public ILevelSequenceSectionInfo? BackWardSections(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new ILevelSequenceSectionInfo?(default(ILevelSequenceSectionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A065 RID: 41061
		// (get) Token: 0x06023E03 RID: 146947 RVA: 0x004F5D64 File Offset: 0x004F3F64
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

		// Token: 0x1700A066 RID: 41062
		// (get) Token: 0x06023E04 RID: 146948 RVA: 0x004F5D90 File Offset: 0x004F3F90
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

		// Token: 0x06023E05 RID: 146949 RVA: 0x004F5DCD File Offset: 0x004F3FCD
		public static Offset<ILevelSequenceFrameEventComponent> CreateILevelSequenceFrameEventComponent(FlatBufferBuilder builder, bool Disabled = false, VectorOffset ForwardSectionsOffset = default(VectorOffset), VectorOffset BackWardSectionsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			ILevelSequenceFrameEventComponent.AddBackWardSections(builder, BackWardSectionsOffset);
			ILevelSequenceFrameEventComponent.AddForwardSections(builder, ForwardSectionsOffset);
			ILevelSequenceFrameEventComponent.AddNullMask(builder, NullMask);
			ILevelSequenceFrameEventComponent.AddDisabled(builder, Disabled);
			return ILevelSequenceFrameEventComponent.EndILevelSequenceFrameEventComponent(builder);
		}

		// Token: 0x06023E06 RID: 146950 RVA: 0x004F5DF9 File Offset: 0x004F3FF9
		public static void StartILevelSequenceFrameEventComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06023E07 RID: 146951 RVA: 0x004F5E02 File Offset: 0x004F4002
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06023E08 RID: 146952 RVA: 0x004F5E0D File Offset: 0x004F400D
		public static void AddForwardSections(FlatBufferBuilder builder, VectorOffset forwardSectionsOffset)
		{
			builder.AddOffset(1, forwardSectionsOffset.Value, 0);
		}

		// Token: 0x06023E09 RID: 146953 RVA: 0x004F5E20 File Offset: 0x004F4020
		public static VectorOffset CreateForwardSectionsVector(FlatBufferBuilder builder, Offset<ILevelSequenceSectionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06023E0A RID: 146954 RVA: 0x004F5E60 File Offset: 0x004F4060
		public static VectorOffset CreateForwardSectionsVectorBlock(FlatBufferBuilder builder, Offset<ILevelSequenceSectionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ILevelSequenceSectionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023E0B RID: 146955 RVA: 0x004F5E7A File Offset: 0x004F407A
		public static VectorOffset CreateForwardSectionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ILevelSequenceSectionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ILevelSequenceSectionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023E0C RID: 146956 RVA: 0x004F5E98 File Offset: 0x004F4098
		public static VectorOffset CreateForwardSectionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ILevelSequenceSectionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06023E0D RID: 146957 RVA: 0x004F5EB1 File Offset: 0x004F40B1
		public static void StartForwardSectionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06023E0E RID: 146958 RVA: 0x004F5EBC File Offset: 0x004F40BC
		public static void AddBackWardSections(FlatBufferBuilder builder, VectorOffset backWardSectionsOffset)
		{
			builder.AddOffset(2, backWardSectionsOffset.Value, 0);
		}

		// Token: 0x06023E0F RID: 146959 RVA: 0x004F5ECC File Offset: 0x004F40CC
		public static VectorOffset CreateBackWardSectionsVector(FlatBufferBuilder builder, Offset<ILevelSequenceSectionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06023E10 RID: 146960 RVA: 0x004F5F0C File Offset: 0x004F410C
		public static VectorOffset CreateBackWardSectionsVectorBlock(FlatBufferBuilder builder, Offset<ILevelSequenceSectionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ILevelSequenceSectionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023E11 RID: 146961 RVA: 0x004F5F26 File Offset: 0x004F4126
		public static VectorOffset CreateBackWardSectionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ILevelSequenceSectionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ILevelSequenceSectionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023E12 RID: 146962 RVA: 0x004F5F44 File Offset: 0x004F4144
		public static VectorOffset CreateBackWardSectionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ILevelSequenceSectionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06023E13 RID: 146963 RVA: 0x004F5F5D File Offset: 0x004F415D
		public static void StartBackWardSectionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06023E14 RID: 146964 RVA: 0x004F5F68 File Offset: 0x004F4168
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06023E15 RID: 146965 RVA: 0x004F5F73 File Offset: 0x004F4173
		public static Offset<ILevelSequenceFrameEventComponent> EndILevelSequenceFrameEventComponent(FlatBufferBuilder builder)
		{
			return new Offset<ILevelSequenceFrameEventComponent>(builder.EndTable());
		}

		// Token: 0x06023E16 RID: 146966 RVA: 0x004F5F80 File Offset: 0x004F4180
		public ILevelSequenceFrameEventComponentT UnPack()
		{
			ILevelSequenceFrameEventComponentT levelSequenceFrameEventComponentT = new ILevelSequenceFrameEventComponentT();
			this.UnPackTo(levelSequenceFrameEventComponentT);
			return levelSequenceFrameEventComponentT;
		}

		// Token: 0x06023E17 RID: 146967 RVA: 0x004F5F9C File Offset: 0x004F419C
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

		// Token: 0x06023E18 RID: 146968 RVA: 0x004F6068 File Offset: 0x004F4268
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

		// Token: 0x0400E7C9 RID: 59337
		private Table __p;
	}
}
