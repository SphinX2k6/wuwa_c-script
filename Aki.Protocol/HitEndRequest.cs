using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200073D RID: 1853
	[NetMessage(EMessageId.HitEndRequest)]
	public sealed class HitEndRequest : IMessage<HitEndRequest>, IMessage, IEquatable<HitEndRequest>, IDeepCloneable<HitEndRequest>, IBufferMessage
	{
		// Token: 0x0600A82C RID: 43052 RVA: 0x00194C7B File Offset: 0x00192E7B
		[NullableContext(1)]
		public static HitEndRequest Create()
		{
			return new HitEndRequest();
		}

		// Token: 0x170021CB RID: 8651
		// (get) Token: 0x0600A82D RID: 43053 RVA: 0x00194C82 File Offset: 0x00192E82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170021CC RID: 8652
		// (get) Token: 0x0600A82E RID: 43054 RVA: 0x00194C85 File Offset: 0x00192E85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HitEndRequest.Descriptor;
			}
		}

		// Token: 0x0600A82F RID: 43055 RVA: 0x00194C8C File Offset: 0x00192E8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HitEndRequest()
		{
		}

		// Token: 0x0600A830 RID: 43056 RVA: 0x00194C94 File Offset: 0x00192E94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HitEndRequest(HitEndRequest other) : this()
		{
			this.combatCommon_ = ((other.combatCommon_ != null) ? other.combatCommon_.Clone() : null);
			this.targetId_ = other.targetId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A831 RID: 43057 RVA: 0x00194CE0 File Offset: 0x00192EE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HitEndRequest Clone()
		{
			return new HitEndRequest(this);
		}

		// Token: 0x170021CD RID: 8653
		// (get) Token: 0x0600A832 RID: 43058 RVA: 0x00194CE8 File Offset: 0x00192EE8
		// (set) Token: 0x0600A833 RID: 43059 RVA: 0x00194CF0 File Offset: 0x00192EF0
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

		// Token: 0x170021CE RID: 8654
		// (get) Token: 0x0600A834 RID: 43060 RVA: 0x00194CF9 File Offset: 0x00192EF9
		// (set) Token: 0x0600A835 RID: 43061 RVA: 0x00194D01 File Offset: 0x00192F01
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

		// Token: 0x0600A836 RID: 43062 RVA: 0x00194D0A File Offset: 0x00192F0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HitEndRequest);
		}

		// Token: 0x0600A837 RID: 43063 RVA: 0x00194D18 File Offset: 0x00192F18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HitEndRequest other)
		{
			return other != null && (other == this || (object.Equals(this.CombatCommon, other.CombatCommon) && this.TargetId == other.TargetId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A838 RID: 43064 RVA: 0x00194D68 File Offset: 0x00192F68
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

		// Token: 0x0600A839 RID: 43065 RVA: 0x00194DBD File Offset: 0x00192FBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A83A RID: 43066 RVA: 0x00194DCA File Offset: 0x00192FCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A83B RID: 43067 RVA: 0x00194DD4 File Offset: 0x00192FD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.combatCommon_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.CombatCommon);
			}
			if (this.TargetId != 0L)
			{
				output.WriteRawTag(80);
				output.WriteInt64(this.TargetId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A83C RID: 43068 RVA: 0x00194E30 File Offset: 0x00193030
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

		// Token: 0x0600A83D RID: 43069 RVA: 0x00194E88 File Offset: 0x00193088
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

		// Token: 0x0600A83E RID: 43070 RVA: 0x00194EF0 File Offset: 0x001930F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A83F RID: 43071 RVA: 0x00194EFC File Offset: 0x001930FC
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
				if (num != 66U)
				{
					if (num != 80U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.TargetId = input.ReadInt64();
					}
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
		}

		// Token: 0x04004D14 RID: 19732
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004D15 RID: 19733
		public const int CombatCommonFieldNumber = 8;

		// Token: 0x04004D16 RID: 19734
		private CombatCommon combatCommon_;

		// Token: 0x04004D17 RID: 19735
		public const int TargetIdFieldNumber = 10;

		// Token: 0x04004D18 RID: 19736
		private long targetId_;
	}
}
