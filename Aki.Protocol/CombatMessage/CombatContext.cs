using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.CombatMessage
{
	// Token: 0x020016FA RID: 5882
	public sealed class CombatContext : IMessage<CombatContext>, IMessage, IEquatable<CombatContext>, IDeepCloneable<CombatContext>, IBufferMessage
	{
		// Token: 0x0601D640 RID: 120384 RVA: 0x00440D80 File Offset: 0x0043EF80
		[NullableContext(1)]
		public static CombatContext Create()
		{
			return new CombatContext();
		}

		// Token: 0x1700636C RID: 25452
		// (get) Token: 0x0601D641 RID: 120385 RVA: 0x00440D87 File Offset: 0x0043EF87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700636D RID: 25453
		// (get) Token: 0x0601D642 RID: 120386 RVA: 0x00440D8A File Offset: 0x0043EF8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CombatContext.Descriptor;
			}
		}

		// Token: 0x0601D643 RID: 120387 RVA: 0x00440D91 File Offset: 0x0043EF91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatContext()
		{
		}

		// Token: 0x0601D644 RID: 120388 RVA: 0x00440D9C File Offset: 0x0043EF9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatContext(CombatContext other) : this()
		{
			switch (other.MessageCase)
			{
			case CombatContext.MessageOneofCase.FsmStateChangeContext:
				this.FsmStateChangeContext = other.FsmStateChangeContext.Clone();
				break;
			case CombatContext.MessageOneofCase.SkillContext:
				this.SkillContext = other.SkillContext.Clone();
				break;
			case CombatContext.MessageOneofCase.MontageContext:
				this.MontageContext = other.MontageContext.Clone();
				break;
			case CombatContext.MessageOneofCase.AddBuffContext:
				this.AddBuffContext = other.AddBuffContext.Clone();
				break;
			case CombatContext.MessageOneofCase.BulletContext:
				this.BulletContext = other.BulletContext.Clone();
				break;
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D645 RID: 120389 RVA: 0x00440E42 File Offset: 0x0043F042
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatContext Clone()
		{
			return new CombatContext(this);
		}

		// Token: 0x1700636E RID: 25454
		// (get) Token: 0x0601D646 RID: 120390 RVA: 0x00440E4A File Offset: 0x0043F04A
		// (set) Token: 0x0601D647 RID: 120391 RVA: 0x00440E62 File Offset: 0x0043F062
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FsmStateChangeContext FsmStateChangeContext
		{
			get
			{
				if (this.messageCase_ != CombatContext.MessageOneofCase.FsmStateChangeContext)
				{
					return null;
				}
				return (FsmStateChangeContext)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatContext.MessageOneofCase.None : CombatContext.MessageOneofCase.FsmStateChangeContext);
			}
		}

		// Token: 0x1700636F RID: 25455
		// (get) Token: 0x0601D648 RID: 120392 RVA: 0x00440E78 File Offset: 0x0043F078
		// (set) Token: 0x0601D649 RID: 120393 RVA: 0x00440E90 File Offset: 0x0043F090
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkillContext SkillContext
		{
			get
			{
				if (this.messageCase_ != CombatContext.MessageOneofCase.SkillContext)
				{
					return null;
				}
				return (SkillContext)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatContext.MessageOneofCase.None : CombatContext.MessageOneofCase.SkillContext);
			}
		}

		// Token: 0x17006370 RID: 25456
		// (get) Token: 0x0601D64A RID: 120394 RVA: 0x00440EA6 File Offset: 0x0043F0A6
		// (set) Token: 0x0601D64B RID: 120395 RVA: 0x00440EBE File Offset: 0x0043F0BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MontageContext MontageContext
		{
			get
			{
				if (this.messageCase_ != CombatContext.MessageOneofCase.MontageContext)
				{
					return null;
				}
				return (MontageContext)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatContext.MessageOneofCase.None : CombatContext.MessageOneofCase.MontageContext);
			}
		}

		// Token: 0x17006371 RID: 25457
		// (get) Token: 0x0601D64C RID: 120396 RVA: 0x00440ED4 File Offset: 0x0043F0D4
		// (set) Token: 0x0601D64D RID: 120397 RVA: 0x00440EEC File Offset: 0x0043F0EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddBuffContext AddBuffContext
		{
			get
			{
				if (this.messageCase_ != CombatContext.MessageOneofCase.AddBuffContext)
				{
					return null;
				}
				return (AddBuffContext)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatContext.MessageOneofCase.None : CombatContext.MessageOneofCase.AddBuffContext);
			}
		}

		// Token: 0x17006372 RID: 25458
		// (get) Token: 0x0601D64E RID: 120398 RVA: 0x00440F02 File Offset: 0x0043F102
		// (set) Token: 0x0601D64F RID: 120399 RVA: 0x00440F1A File Offset: 0x0043F11A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BulletContext BulletContext
		{
			get
			{
				if (this.messageCase_ != CombatContext.MessageOneofCase.BulletContext)
				{
					return null;
				}
				return (BulletContext)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatContext.MessageOneofCase.None : CombatContext.MessageOneofCase.BulletContext);
			}
		}

		// Token: 0x17006373 RID: 25459
		// (get) Token: 0x0601D650 RID: 120400 RVA: 0x00440F30 File Offset: 0x0043F130
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatContext.MessageOneofCase MessageCase
		{
			get
			{
				return this.messageCase_;
			}
		}

		// Token: 0x0601D651 RID: 120401 RVA: 0x00440F38 File Offset: 0x0043F138
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearMessage()
		{
			this.messageCase_ = CombatContext.MessageOneofCase.None;
			this.message_ = null;
		}

		// Token: 0x0601D652 RID: 120402 RVA: 0x00440F48 File Offset: 0x0043F148
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CombatContext);
		}

		// Token: 0x0601D653 RID: 120403 RVA: 0x00440F58 File Offset: 0x0043F158
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CombatContext other)
		{
			return other != null && (other == this || (object.Equals(this.FsmStateChangeContext, other.FsmStateChangeContext) && object.Equals(this.SkillContext, other.SkillContext) && object.Equals(this.MontageContext, other.MontageContext) && object.Equals(this.AddBuffContext, other.AddBuffContext) && object.Equals(this.BulletContext, other.BulletContext) && this.MessageCase == other.MessageCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D654 RID: 120404 RVA: 0x00440FFC File Offset: 0x0043F1FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.messageCase_ == CombatContext.MessageOneofCase.FsmStateChangeContext)
			{
				num ^= this.FsmStateChangeContext.GetHashCode();
			}
			if (this.messageCase_ == CombatContext.MessageOneofCase.SkillContext)
			{
				num ^= this.SkillContext.GetHashCode();
			}
			if (this.messageCase_ == CombatContext.MessageOneofCase.MontageContext)
			{
				num ^= this.MontageContext.GetHashCode();
			}
			if (this.messageCase_ == CombatContext.MessageOneofCase.AddBuffContext)
			{
				num ^= this.AddBuffContext.GetHashCode();
			}
			if (this.messageCase_ == CombatContext.MessageOneofCase.BulletContext)
			{
				num ^= this.BulletContext.GetHashCode();
			}
			num ^= (int)this.messageCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601D655 RID: 120405 RVA: 0x0044109E File Offset: 0x0043F29E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D656 RID: 120406 RVA: 0x004410AB File Offset: 0x0043F2AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D657 RID: 120407 RVA: 0x004410B4 File Offset: 0x0043F2B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.messageCase_ == CombatContext.MessageOneofCase.FsmStateChangeContext)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.FsmStateChangeContext);
			}
			if (this.messageCase_ == CombatContext.MessageOneofCase.SkillContext)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.SkillContext);
			}
			if (this.messageCase_ == CombatContext.MessageOneofCase.MontageContext)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.MontageContext);
			}
			if (this.messageCase_ == CombatContext.MessageOneofCase.AddBuffContext)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.AddBuffContext);
			}
			if (this.messageCase_ == CombatContext.MessageOneofCase.BulletContext)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.BulletContext);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D658 RID: 120408 RVA: 0x00441168 File Offset: 0x0043F368
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.messageCase_ == CombatContext.MessageOneofCase.FsmStateChangeContext)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FsmStateChangeContext);
			}
			if (this.messageCase_ == CombatContext.MessageOneofCase.SkillContext)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SkillContext);
			}
			if (this.messageCase_ == CombatContext.MessageOneofCase.MontageContext)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MontageContext);
			}
			if (this.messageCase_ == CombatContext.MessageOneofCase.AddBuffContext)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AddBuffContext);
			}
			if (this.messageCase_ == CombatContext.MessageOneofCase.BulletContext)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BulletContext);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601D659 RID: 120409 RVA: 0x0044120C File Offset: 0x0043F40C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CombatContext other)
		{
			if (other == null)
			{
				return;
			}
			switch (other.MessageCase)
			{
			case CombatContext.MessageOneofCase.FsmStateChangeContext:
				if (this.FsmStateChangeContext == null)
				{
					this.FsmStateChangeContext = new FsmStateChangeContext();
				}
				this.FsmStateChangeContext.MergeFrom(other.FsmStateChangeContext);
				break;
			case CombatContext.MessageOneofCase.SkillContext:
				if (this.SkillContext == null)
				{
					this.SkillContext = new SkillContext();
				}
				this.SkillContext.MergeFrom(other.SkillContext);
				break;
			case CombatContext.MessageOneofCase.MontageContext:
				if (this.MontageContext == null)
				{
					this.MontageContext = new MontageContext();
				}
				this.MontageContext.MergeFrom(other.MontageContext);
				break;
			case CombatContext.MessageOneofCase.AddBuffContext:
				if (this.AddBuffContext == null)
				{
					this.AddBuffContext = new AddBuffContext();
				}
				this.AddBuffContext.MergeFrom(other.AddBuffContext);
				break;
			case CombatContext.MessageOneofCase.BulletContext:
				if (this.BulletContext == null)
				{
					this.BulletContext = new BulletContext();
				}
				this.BulletContext.MergeFrom(other.BulletContext);
				break;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601D65A RID: 120410 RVA: 0x0044131B File Offset: 0x0043F51B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D65B RID: 120411 RVA: 0x00441324 File Offset: 0x0043F524
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if ((num & 7U) == 4U)
				{
					return;
				}
				if (num <= 18U)
				{
					if (num == 10U)
					{
						FsmStateChangeContext fsmStateChangeContext = new FsmStateChangeContext();
						if (this.messageCase_ == CombatContext.MessageOneofCase.FsmStateChangeContext)
						{
							fsmStateChangeContext.MergeFrom(this.FsmStateChangeContext);
						}
						input.ReadMessage(fsmStateChangeContext);
						this.FsmStateChangeContext = fsmStateChangeContext;
						continue;
					}
					if (num == 18U)
					{
						SkillContext skillContext = new SkillContext();
						if (this.messageCase_ == CombatContext.MessageOneofCase.SkillContext)
						{
							skillContext.MergeFrom(this.SkillContext);
						}
						input.ReadMessage(skillContext);
						this.SkillContext = skillContext;
						continue;
					}
				}
				else
				{
					if (num == 26U)
					{
						MontageContext montageContext = new MontageContext();
						if (this.messageCase_ == CombatContext.MessageOneofCase.MontageContext)
						{
							montageContext.MergeFrom(this.MontageContext);
						}
						input.ReadMessage(montageContext);
						this.MontageContext = montageContext;
						continue;
					}
					if (num == 34U)
					{
						AddBuffContext addBuffContext = new AddBuffContext();
						if (this.messageCase_ == CombatContext.MessageOneofCase.AddBuffContext)
						{
							addBuffContext.MergeFrom(this.AddBuffContext);
						}
						input.ReadMessage(addBuffContext);
						this.AddBuffContext = addBuffContext;
						continue;
					}
					if (num == 42U)
					{
						BulletContext bulletContext = new BulletContext();
						if (this.messageCase_ == CombatContext.MessageOneofCase.BulletContext)
						{
							bulletContext.MergeFrom(this.BulletContext);
						}
						input.ReadMessage(bulletContext);
						this.BulletContext = bulletContext;
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400C72B RID: 50987
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C72C RID: 50988
		public const int FsmStateChangeContextFieldNumber = 1;

		// Token: 0x0400C72D RID: 50989
		public const int SkillContextFieldNumber = 2;

		// Token: 0x0400C72E RID: 50990
		public const int MontageContextFieldNumber = 3;

		// Token: 0x0400C72F RID: 50991
		public const int AddBuffContextFieldNumber = 4;

		// Token: 0x0400C730 RID: 50992
		public const int BulletContextFieldNumber = 5;

		// Token: 0x0400C731 RID: 50993
		private object message_;

		// Token: 0x0400C732 RID: 50994
		private CombatContext.MessageOneofCase messageCase_;

		// Token: 0x02001A9E RID: 6814
		public enum MessageOneofCase
		{
			// Token: 0x0400D055 RID: 53333
			None,
			// Token: 0x0400D056 RID: 53334
			FsmStateChangeContext,
			// Token: 0x0400D057 RID: 53335
			SkillContext,
			// Token: 0x0400D058 RID: 53336
			MontageContext,
			// Token: 0x0400D059 RID: 53337
			AddBuffContext,
			// Token: 0x0400D05A RID: 53338
			BulletContext
		}
	}
}
