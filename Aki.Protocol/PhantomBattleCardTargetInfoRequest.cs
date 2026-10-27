using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C65 RID: 3173
	[NetMessage(EMessageId.PhantomBattleCardTargetInfoRequest)]
	public sealed class PhantomBattleCardTargetInfoRequest : IMessage<PhantomBattleCardTargetInfoRequest>, IMessage, IEquatable<PhantomBattleCardTargetInfoRequest>, IDeepCloneable<PhantomBattleCardTargetInfoRequest>, IBufferMessage
	{
		// Token: 0x06011332 RID: 70450 RVA: 0x0028494C File Offset: 0x00282B4C
		[NullableContext(1)]
		public static PhantomBattleCardTargetInfoRequest Create()
		{
			return new PhantomBattleCardTargetInfoRequest();
		}

		// Token: 0x170038DD RID: 14557
		// (get) Token: 0x06011333 RID: 70451 RVA: 0x00284953 File Offset: 0x00282B53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170038DE RID: 14558
		// (get) Token: 0x06011334 RID: 70452 RVA: 0x00284956 File Offset: 0x00282B56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleCardTargetInfoRequest.Descriptor;
			}
		}

		// Token: 0x06011335 RID: 70453 RVA: 0x0028495D File Offset: 0x00282B5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardTargetInfoRequest()
		{
		}

		// Token: 0x06011336 RID: 70454 RVA: 0x00284965 File Offset: 0x00282B65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardTargetInfoRequest(PhantomBattleCardTargetInfoRequest other) : this()
		{
			this.cardUId_ = other.cardUId_;
			this.skillId_ = other.skillId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011337 RID: 70455 RVA: 0x00284996 File Offset: 0x00282B96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardTargetInfoRequest Clone()
		{
			return new PhantomBattleCardTargetInfoRequest(this);
		}

		// Token: 0x170038DF RID: 14559
		// (get) Token: 0x06011338 RID: 70456 RVA: 0x0028499E File Offset: 0x00282B9E
		// (set) Token: 0x06011339 RID: 70457 RVA: 0x002849A6 File Offset: 0x00282BA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CardUId
		{
			get
			{
				return this.cardUId_;
			}
			set
			{
				this.cardUId_ = value;
			}
		}

		// Token: 0x170038E0 RID: 14560
		// (get) Token: 0x0601133A RID: 70458 RVA: 0x002849AF File Offset: 0x00282BAF
		// (set) Token: 0x0601133B RID: 70459 RVA: 0x002849B7 File Offset: 0x00282BB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SkillId
		{
			get
			{
				return this.skillId_;
			}
			set
			{
				this.skillId_ = value;
			}
		}

		// Token: 0x0601133C RID: 70460 RVA: 0x002849C0 File Offset: 0x00282BC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleCardTargetInfoRequest);
		}

		// Token: 0x0601133D RID: 70461 RVA: 0x002849CE File Offset: 0x00282BCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleCardTargetInfoRequest other)
		{
			return other != null && (other == this || (this.CardUId == other.CardUId && this.SkillId == other.SkillId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601133E RID: 70462 RVA: 0x00284A0C File Offset: 0x00282C0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CardUId != 0)
			{
				num ^= this.CardUId.GetHashCode();
			}
			if (this.SkillId != 0)
			{
				num ^= this.SkillId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601133F RID: 70463 RVA: 0x00284A64 File Offset: 0x00282C64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011340 RID: 70464 RVA: 0x00284A71 File Offset: 0x00282C71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011341 RID: 70465 RVA: 0x00284A7C File Offset: 0x00282C7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CardUId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.CardUId);
			}
			if (this.SkillId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.SkillId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011342 RID: 70466 RVA: 0x00284AD8 File Offset: 0x00282CD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CardUId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CardUId);
			}
			if (this.SkillId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkillId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011343 RID: 70467 RVA: 0x00284B30 File Offset: 0x00282D30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleCardTargetInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CardUId != 0)
			{
				this.CardUId = other.CardUId;
			}
			if (other.SkillId != 0)
			{
				this.SkillId = other.SkillId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011344 RID: 70468 RVA: 0x00284B80 File Offset: 0x00282D80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011345 RID: 70469 RVA: 0x00284B8C File Offset: 0x00282D8C
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
				if (num != 32U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.SkillId = input.ReadInt32();
					}
				}
				else
				{
					this.CardUId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006CCB RID: 27851
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006CCC RID: 27852
		public const int CardUIdFieldNumber = 4;

		// Token: 0x04006CCD RID: 27853
		private int cardUId_;

		// Token: 0x04006CCE RID: 27854
		public const int SkillIdFieldNumber = 15;

		// Token: 0x04006CCF RID: 27855
		private int skillId_;
	}
}
