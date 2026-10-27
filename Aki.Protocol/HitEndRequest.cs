using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000751 RID: 1873
	[NetMessage(EMessageId.HitEndRequest)]
	public sealed class HitEndRequest : IMessage<HitEndRequest>, IMessage, IEquatable<HitEndRequest>, IDeepCloneable<HitEndRequest>, IBufferMessage
	{
		// Token: 0x0600A982 RID: 43394 RVA: 0x001976A7 File Offset: 0x001958A7
		[NullableContext(1)]
		public static HitEndRequest Create()
		{
			return new HitEndRequest();
		}

		// Token: 0x17002215 RID: 8725
		// (get) Token: 0x0600A983 RID: 43395 RVA: 0x001976AE File Offset: 0x001958AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002216 RID: 8726
		// (get) Token: 0x0600A984 RID: 43396 RVA: 0x001976B1 File Offset: 0x001958B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HitEndRequest.Descriptor;
			}
		}

		// Token: 0x0600A985 RID: 43397 RVA: 0x001976B8 File Offset: 0x001958B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HitEndRequest()
		{
		}

		// Token: 0x0600A986 RID: 43398 RVA: 0x001976C0 File Offset: 0x001958C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HitEndRequest(HitEndRequest other) : this()
		{
			this.combatCommon_ = ((other.combatCommon_ != null) ? other.combatCommon_.Clone() : null);
			this.targetId_ = other.targetId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A987 RID: 43399 RVA: 0x0019770C File Offset: 0x0019590C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HitEndRequest Clone()
		{
			return new HitEndRequest(this);
		}

		// Token: 0x17002217 RID: 8727
		// (get) Token: 0x0600A988 RID: 43400 RVA: 0x00197714 File Offset: 0x00195914
		// (set) Token: 0x0600A989 RID: 43401 RVA: 0x0019771C File Offset: 0x0019591C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatCommon CombatCommon
		{
			get
			{
				return this.combatCommon_;
			}
			set
			{
				this.combatCommon_ = value;
			}
		}

		// Token: 0x17002218 RID: 8728
		// (get) Token: 0x0600A98A RID: 43402 RVA: 0x00197725 File Offset: 0x00195925
		// (set) Token: 0x0600A98B RID: 43403 RVA: 0x0019772D File Offset: 0x0019592D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long TargetId
		{
			get
			{
				return this.targetId_;
			}
			set
			{
				this.targetId_ = value;
			}
		}

		// Token: 0x0600A98C RID: 43404 RVA: 0x00197736 File Offset: 0x00195936
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HitEndRequest);
		}

		// Token: 0x0600A98D RID: 43405 RVA: 0x00197744 File Offset: 0x00195944
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HitEndRequest other)
		{
			return other != null && (other == this || (object.Equals(this.CombatCommon, other.CombatCommon) && this.TargetId == other.TargetId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A98E RID: 43406 RVA: 0x00197794 File Offset: 0x00195994
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.combatCommon_ != null)
			{
				num ^= this.CombatCommon.GetHashCode();
			}
			if (this.TargetId != 0L)
			{
				num ^= this.TargetId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A98F RID: 43407 RVA: 0x001977E9 File Offset: 0x001959E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A990 RID: 43408 RVA: 0x001977F6 File Offset: 0x001959F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A991 RID: 43409 RVA: 0x00197800 File Offset: 0x00195A00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TargetId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.TargetId);
			}
			if (this.combatCommon_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.CombatCommon);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A992 RID: 43410 RVA: 0x00197858 File Offset: 0x00195A58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.combatCommon_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CombatCommon);
			}
			if (this.TargetId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.TargetId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A993 RID: 43411 RVA: 0x001978B0 File Offset: 0x00195AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HitEndRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.combatCommon_ != null)
			{
				if (this.combatCommon_ == null)
				{
					this.CombatCommon = new CombatCommon();
				}
				this.CombatCommon.MergeFrom(other.CombatCommon);
			}
			if (other.TargetId != 0L)
			{
				this.TargetId = other.TargetId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A994 RID: 43412 RVA: 0x00197918 File Offset: 0x00195B18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A995 RID: 43413 RVA: 0x00197924 File Offset: 0x00195B24
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
				if (num != 8U)
				{
					if (num != 42U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.combatCommon_ == null)
						{
							this.CombatCommon = new CombatCommon();
						}
						input.ReadMessage(this.CombatCommon);
					}
				}
				else
				{
					this.TargetId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04004D1B RID: 19739
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004D1C RID: 19740
		public const int CombatCommonFieldNumber = 5;

		// Token: 0x04004D1D RID: 19741
		private CombatCommon combatCommon_;

		// Token: 0x04004D1E RID: 19742
		public const int TargetIdFieldNumber = 1;

		// Token: 0x04004D1F RID: 19743
		private long targetId_;
	}
}
