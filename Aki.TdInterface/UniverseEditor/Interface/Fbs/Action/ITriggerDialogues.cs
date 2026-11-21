using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C6B RID: 31851
	public struct ITriggerDialogues : IFlatbufferObject
	{
		// Token: 0x1700EE76 RID: 61046
		// (get) Token: 0x060396C7 RID: 235207 RVA: 0x007C0A4E File Offset: 0x007BEC4E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060396C8 RID: 235208 RVA: 0x007C0A5B File Offset: 0x007BEC5B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060396C9 RID: 235209 RVA: 0x007C0A64 File Offset: 0x007BEC64
		public static ITriggerDialogues GetRootAsITriggerDialogues(ByteBuffer _bb)
		{
			return ITriggerDialogues.GetRootAsITriggerDialogues(_bb, default(ITriggerDialogues));
		}

		// Token: 0x060396CA RID: 235210 RVA: 0x007C0A80 File Offset: 0x007BEC80
		public static ITriggerDialogues GetRootAsITriggerDialogues(ByteBuffer _bb, ITriggerDialogues obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060396CB RID: 235211 RVA: 0x007C0A9D File Offset: 0x007BEC9D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060396CC RID: 235212 RVA: 0x007C0AAC File Offset: 0x007BECAC
		public ITriggerDialogues __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EE77 RID: 61047
		// (get) Token: 0x060396CD RID: 235213 RVA: 0x007C0ABC File Offset: 0x007BECBC
		public EInteractEffectType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EInteractEffectType.ModifyTipText;
				}
				return (EInteractEffectType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700EE78 RID: 61048
		// (get) Token: 0x060396CE RID: 235214 RVA: 0x007C0AF8 File Offset: 0x007BECF8
		public float DelayTime
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060396CF RID: 235215 RVA: 0x007C0B38 File Offset: 0x007BED38
		public string Talks(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700EE79 RID: 61049
		// (get) Token: 0x060396D0 RID: 235216 RVA: 0x007C0B74 File Offset: 0x007BED74
		public int TalksLength
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

		// Token: 0x1700EE7A RID: 61050
		// (get) Token: 0x060396D1 RID: 235217 RVA: 0x007C0BA0 File Offset: 0x007BEDA0
		public IFocusObject? FocusObject
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IFocusObject?(default(IFocusObject).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700EE7B RID: 61051
		// (get) Token: 0x060396D2 RID: 235218 RVA: 0x007C0C00 File Offset: 0x007BEE00
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060396D3 RID: 235219 RVA: 0x007C0C3D File Offset: 0x007BEE3D
		public static Offset<ITriggerDialogues> CreateITriggerDialogues(FlatBufferBuilder builder, EInteractEffectType Type = EInteractEffectType.ModifyTipText, float DelayTime = 0f, VectorOffset TalksOffset = default(VectorOffset), Offset<IFocusObject> FocusObjectOffset = default(Offset<IFocusObject>), byte NullMask = 0)
		{
			builder.StartTable(5);
			ITriggerDialogues.AddFocusObject(builder, FocusObjectOffset);
			ITriggerDialogues.AddTalks(builder, TalksOffset);
			ITriggerDialogues.AddDelayTime(builder, DelayTime);
			ITriggerDialogues.AddNullMask(builder, NullMask);
			ITriggerDialogues.AddType(builder, Type);
			return ITriggerDialogues.EndITriggerDialogues(builder);
		}

		// Token: 0x060396D4 RID: 235220 RVA: 0x007C0C71 File Offset: 0x007BEE71
		public static void StartITriggerDialogues(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x060396D5 RID: 235221 RVA: 0x007C0C7A File Offset: 0x007BEE7A
		public static void AddType(FlatBufferBuilder builder, EInteractEffectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060396D6 RID: 235222 RVA: 0x007C0C85 File Offset: 0x007BEE85
		public static void AddDelayTime(FlatBufferBuilder builder, float delayTime)
		{
			builder.AddFloat(1, delayTime, 0.0);
		}

		// Token: 0x060396D7 RID: 235223 RVA: 0x007C0C98 File Offset: 0x007BEE98
		public static void AddTalks(FlatBufferBuilder builder, VectorOffset talksOffset)
		{
			builder.AddOffset(2, talksOffset.Value, 0);
		}

		// Token: 0x060396D8 RID: 235224 RVA: 0x007C0CA8 File Offset: 0x007BEEA8
		public static VectorOffset CreateTalksVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060396D9 RID: 235225 RVA: 0x007C0CE8 File Offset: 0x007BEEE8
		public static VectorOffset CreateTalksVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x060396DA RID: 235226 RVA: 0x007C0D02 File Offset: 0x007BEF02
		public static VectorOffset CreateTalksVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x060396DB RID: 235227 RVA: 0x007C0D20 File Offset: 0x007BEF20
		public static VectorOffset CreateTalksVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060396DC RID: 235228 RVA: 0x007C0D39 File Offset: 0x007BEF39
		public static void StartTalksVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060396DD RID: 235229 RVA: 0x007C0D44 File Offset: 0x007BEF44
		public static void AddFocusObject(FlatBufferBuilder builder, Offset<IFocusObject> focusObjectOffset)
		{
			builder.AddOffset(3, focusObjectOffset.Value, 0);
		}

		// Token: 0x060396DE RID: 235230 RVA: 0x007C0D54 File Offset: 0x007BEF54
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x060396DF RID: 235231 RVA: 0x007C0D5F File Offset: 0x007BEF5F
		public static Offset<ITriggerDialogues> EndITriggerDialogues(FlatBufferBuilder builder)
		{
			return new Offset<ITriggerDialogues>(builder.EndTable());
		}

		// Token: 0x060396E0 RID: 235232 RVA: 0x007C0D6C File Offset: 0x007BEF6C
		public ITriggerDialoguesT UnPack()
		{
			ITriggerDialoguesT triggerDialoguesT = new ITriggerDialoguesT();
			this.UnPackTo(triggerDialoguesT);
			return triggerDialoguesT;
		}

		// Token: 0x060396E1 RID: 235233 RVA: 0x007C0D88 File Offset: 0x007BEF88
		public void UnPackTo(ITriggerDialoguesT _o)
		{
			_o.Type = this.Type;
			_o.DelayTime = this.DelayTime;
			_o.Talks = new List<string>();
			for (int i = 0; i < this.TalksLength; i++)
			{
				_o.Talks.Add(this.Talks(i));
			}
			_o.FocusObject = ((this.FocusObject != null) ? this.FocusObject.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060396E2 RID: 235234 RVA: 0x007C0E18 File Offset: 0x007BF018
		public static Offset<ITriggerDialogues> Pack(FlatBufferBuilder builder, ITriggerDialoguesT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITriggerDialogues>);
			}
			VectorOffset talksOffset = default(VectorOffset);
			if (_o.Talks != null)
			{
				StringOffset[] array = new StringOffset[_o.Talks.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = builder.CreateString(_o.Talks[i]);
				}
				talksOffset = ITriggerDialogues.CreateTalksVector(builder, array);
			}
			Offset<IFocusObject> focusObjectOffset = (_o.FocusObject == null) ? default(Offset<IFocusObject>) : IFocusObject.Pack(builder, _o.FocusObject);
			return ITriggerDialogues.CreateITriggerDialogues(builder, _o.Type, _o.DelayTime, talksOffset, focusObjectOffset, _o.NullMask);
		}

		// Token: 0x04013333 RID: 78643
		private Table __p;
	}
}
