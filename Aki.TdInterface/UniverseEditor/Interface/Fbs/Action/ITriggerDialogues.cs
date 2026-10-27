using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007478 RID: 29816
	public struct ITriggerDialogues : IFlatbufferObject
	{
		// Token: 0x1700E259 RID: 57945
		// (get) Token: 0x060362DE RID: 221918 RVA: 0x0075DD22 File Offset: 0x0075BF22
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060362DF RID: 221919 RVA: 0x0075DD2F File Offset: 0x0075BF2F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060362E0 RID: 221920 RVA: 0x0075DD38 File Offset: 0x0075BF38
		public static ITriggerDialogues GetRootAsITriggerDialogues(ByteBuffer _bb)
		{
			return ITriggerDialogues.GetRootAsITriggerDialogues(_bb, default(ITriggerDialogues));
		}

		// Token: 0x060362E1 RID: 221921 RVA: 0x0075DD54 File Offset: 0x0075BF54
		public static ITriggerDialogues GetRootAsITriggerDialogues(ByteBuffer _bb, ITriggerDialogues obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060362E2 RID: 221922 RVA: 0x0075DD71 File Offset: 0x0075BF71
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060362E3 RID: 221923 RVA: 0x0075DD80 File Offset: 0x0075BF80
		public ITriggerDialogues __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E25A RID: 57946
		// (get) Token: 0x060362E4 RID: 221924 RVA: 0x0075DD90 File Offset: 0x0075BF90
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

		// Token: 0x1700E25B RID: 57947
		// (get) Token: 0x060362E5 RID: 221925 RVA: 0x0075DDCC File Offset: 0x0075BFCC
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

		// Token: 0x060362E6 RID: 221926 RVA: 0x0075DE0C File Offset: 0x0075C00C
		public string Talks(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700E25C RID: 57948
		// (get) Token: 0x060362E7 RID: 221927 RVA: 0x0075DE48 File Offset: 0x0075C048
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

		// Token: 0x1700E25D RID: 57949
		// (get) Token: 0x060362E8 RID: 221928 RVA: 0x0075DE74 File Offset: 0x0075C074
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

		// Token: 0x1700E25E RID: 57950
		// (get) Token: 0x060362E9 RID: 221929 RVA: 0x0075DED4 File Offset: 0x0075C0D4
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

		// Token: 0x060362EA RID: 221930 RVA: 0x0075DF11 File Offset: 0x0075C111
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

		// Token: 0x060362EB RID: 221931 RVA: 0x0075DF45 File Offset: 0x0075C145
		public static void StartITriggerDialogues(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x060362EC RID: 221932 RVA: 0x0075DF4E File Offset: 0x0075C14E
		public static void AddType(FlatBufferBuilder builder, EInteractEffectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060362ED RID: 221933 RVA: 0x0075DF59 File Offset: 0x0075C159
		public static void AddDelayTime(FlatBufferBuilder builder, float delayTime)
		{
			builder.AddFloat(1, delayTime, 0.0);
		}

		// Token: 0x060362EE RID: 221934 RVA: 0x0075DF6C File Offset: 0x0075C16C
		public static void AddTalks(FlatBufferBuilder builder, VectorOffset talksOffset)
		{
			builder.AddOffset(2, talksOffset.Value, 0);
		}

		// Token: 0x060362EF RID: 221935 RVA: 0x0075DF7C File Offset: 0x0075C17C
		public static VectorOffset CreateTalksVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060362F0 RID: 221936 RVA: 0x0075DFBC File Offset: 0x0075C1BC
		public static VectorOffset CreateTalksVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x060362F1 RID: 221937 RVA: 0x0075DFD6 File Offset: 0x0075C1D6
		public static VectorOffset CreateTalksVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x060362F2 RID: 221938 RVA: 0x0075DFF4 File Offset: 0x0075C1F4
		public static VectorOffset CreateTalksVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060362F3 RID: 221939 RVA: 0x0075E00D File Offset: 0x0075C20D
		public static void StartTalksVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060362F4 RID: 221940 RVA: 0x0075E018 File Offset: 0x0075C218
		public static void AddFocusObject(FlatBufferBuilder builder, Offset<IFocusObject> focusObjectOffset)
		{
			builder.AddOffset(3, focusObjectOffset.Value, 0);
		}

		// Token: 0x060362F5 RID: 221941 RVA: 0x0075E028 File Offset: 0x0075C228
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x060362F6 RID: 221942 RVA: 0x0075E033 File Offset: 0x0075C233
		public static Offset<ITriggerDialogues> EndITriggerDialogues(FlatBufferBuilder builder)
		{
			return new Offset<ITriggerDialogues>(builder.EndTable());
		}

		// Token: 0x060362F7 RID: 221943 RVA: 0x0075E040 File Offset: 0x0075C240
		public ITriggerDialoguesT UnPack()
		{
			ITriggerDialoguesT triggerDialoguesT = new ITriggerDialoguesT();
			this.UnPackTo(triggerDialoguesT);
			return triggerDialoguesT;
		}

		// Token: 0x060362F8 RID: 221944 RVA: 0x0075E05C File Offset: 0x0075C25C
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

		// Token: 0x060362F9 RID: 221945 RVA: 0x0075E0EC File Offset: 0x0075C2EC
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

		// Token: 0x0401230C RID: 74508
		private Table __p;
	}
}
