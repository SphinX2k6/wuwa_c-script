using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.CombatMessage
{
	// Token: 0x0200167E RID: 5758
	public sealed class CombatContext : IMessage<CombatContext>, IMessage, IEquatable<CombatContext>, IDeepCloneable<CombatContext>, IBufferMessage
	{
		// Token: 0x0601CB73 RID: 117619 RVA: 0x004250C0 File Offset: 0x004232C0
		[NullableContext(1)]
		public static CombatContext Create()
		{
			return new CombatContext();
		}

		// Token: 0x170060C8 RID: 24776
		// (get) Token: 0x0601CB74 RID: 117620 RVA: 0x004250C7 File Offset: 0x004232C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170060C9 RID: 24777
		// (get) Token: 0x0601CB75 RID: 117621 RVA: 0x004250CA File Offset: 0x004232CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CombatContext.Descriptor;
			}
		}

		// Token: 0x0601CB76 RID: 117622 RVA: 0x004250D1 File Offset: 0x004232D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatContext()
		{
		}

		// Token: 0x0601CB77 RID: 117623 RVA: 0x004250DC File Offset: 0x004232DC
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

		// Token: 0x0601CB78 RID: 117624 RVA: 0x00425182 File Offset: 0x00423382
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatContext Clone()
		{
			return new CombatContext(this);
		}

		// Token: 0x170060CA RID: 24778
		// (get) Token: 0x0601CB79 RID: 117625 RVA: 0x0042518A File Offset: 0x0042338A
		// (set) Token: 0x0601CB7A RID: 117626 RVA: 0x004251A2 File Offset: 0x004233A2
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

		// Token: 0x170060CB RID: 24779
		// (get) Token: 0x0601CB7B RID: 117627 RVA: 0x004251B8 File Offset: 0x004233B8
		// (set) Token: 0x0601CB7C RID: 117628 RVA: 0x004251D0 File Offset: 0x004233D0
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

		// Token: 0x170060CC RID: 24780
		// (get) Token: 0x0601CB7D RID: 117629 RVA: 0x004251E6 File Offset: 0x004233E6
		// (set) Token: 0x0601CB7E RID: 117630 RVA: 0x004251FE File Offset: 0x004233FE
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

		// Token: 0x170060CD RID: 24781
		// (get) Token: 0x0601CB7F RID: 117631 RVA: 0x00425214 File Offset: 0x00423414
		// (set) Token: 0x0601CB80 RID: 117632 RVA: 0x0042522C File Offset: 0x0042342C
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

		// Token: 0x170060CE RID: 24782
		// (get) Token: 0x0601CB81 RID: 117633 RVA: 0x00425242 File Offset: 0x00423442
		// (set) Token: 0x0601CB82 RID: 117634 RVA: 0x0042525A File Offset: 0x0042345A
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

		// Token: 0x170060CF RID: 24783
		// (get) Token: 0x0601CB83 RID: 117635 RVA: 0x00425270 File Offset: 0x00423470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatContext.MessageOneofCase MessageCase
		{
			get
			{
				return this.messageCase_;
			}
		}

		// Token: 0x0601CB84 RID: 117636 RVA: 0x00425278 File Offset: 0x00423478
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearMessage()
		{
			this.messageCase_ = CombatContext.MessageOneofCase.None;
			this.message_ = null;
		}

		// Token: 0x0601CB85 RID: 117637 RVA: 0x00425288 File Offset: 0x00423488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CombatContext);
		}

		// Token: 0x0601CB86 RID: 117638 RVA: 0x00425298 File Offset: 0x00423498
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CombatContext other)
		{
			return other != null && (other == this || (object.Equals(this.FsmStateChangeContext, other.FsmStateChangeContext) && object.Equals(this.SkillContext, other.SkillContext) && object.Equals(this.MontageContext, other.MontageContext) && object.Equals(this.AddBuffContext, other.AddBuffContext) && object.Equals(this.BulletContext, other.BulletContext) && this.MessageCase == other.MessageCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CB87 RID: 117639 RVA: 0x0042533C File Offset: 0x0042353C
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

		// Token: 0x0601CB88 RID: 117640 RVA: 0x004253DE File Offset: 0x004235DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CB89 RID: 117641 RVA: 0x004253EB File Offset: 0x004235EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CB8A RID: 117642 RVA: 0x004253F4 File Offset: 0x004235F4
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

		// Token: 0x0601CB8B RID: 117643 RVA: 0x004254A8 File Offset: 0x004236A8
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

		// Token: 0x0601CB8C RID: 117644 RVA: 0x0042554C File Offset: 0x0042374C
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

		// Token: 0x0601CB8D RID: 117645 RVA: 0x0042565B File Offset: 0x0042385B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CB8E RID: 117646 RVA: 0x00425664 File Offset: 0x00423864
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

		// Token: 0x0400C1FF RID: 49663
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C200 RID: 49664
		public const int FsmStateChangeContextFieldNumber = 1;

		// Token: 0x0400C201 RID: 49665
		public const int SkillContextFieldNumber = 2;

		// Token: 0x0400C202 RID: 49666
		public const int MontageContextFieldNumber = 3;

		// Token: 0x0400C203 RID: 49667
		public const int AddBuffContextFieldNumber = 4;

		// Token: 0x0400C204 RID: 49668
		public const int BulletContextFieldNumber = 5;

		// Token: 0x0400C205 RID: 49669
		private object message_;

		// Token: 0x0400C206 RID: 49670
		private CombatContext.MessageOneofCase messageCase_;

		// Token: 0x020019FC RID: 6652
		public enum MessageOneofCase
		{
			// Token: 0x0400CAEA RID: 51946
			None,
			// Token: 0x0400CAEB RID: 51947
			FsmStateChangeContext,
			// Token: 0x0400CAEC RID: 51948
			SkillContext,
			// Token: 0x0400CAED RID: 51949
			MontageContext,
			// Token: 0x0400CAEE RID: 51950
			AddBuffContext,
			// Token: 0x0400CAEF RID: 51951
			BulletContext
		}
	}
}
