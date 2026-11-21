using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000124 RID: 292
	public sealed class AttachTargetEntityInfo : IMessage<AttachTargetEntityInfo>, IMessage, IEquatable<AttachTargetEntityInfo>, IDeepCloneable<AttachTargetEntityInfo>, IBufferMessage
	{
		// Token: 0x06002770 RID: 10096 RVA: 0x000689C9 File Offset: 0x00066BC9
		[NullableContext(1)]
		public static AttachTargetEntityInfo Create()
		{
			return new AttachTargetEntityInfo();
		}

		// Token: 0x17000595 RID: 1429
		// (get) Token: 0x06002771 RID: 10097 RVA: 0x000689D0 File Offset: 0x00066BD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000596 RID: 1430
		// (get) Token: 0x06002772 RID: 10098 RVA: 0x000689D3 File Offset: 0x00066BD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AttachTargetEntityInfo.Descriptor;
			}
		}

		// Token: 0x06002773 RID: 10099 RVA: 0x000689DA File Offset: 0x00066BDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AttachTargetEntityInfo()
		{
		}

		// Token: 0x06002774 RID: 10100 RVA: 0x000689ED File Offset: 0x00066BED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AttachTargetEntityInfo(AttachTargetEntityInfo other) : this()
		{
			this.targetConfigId_ = other.targetConfigId_;
			this.actor_ = other.actor_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002775 RID: 10101 RVA: 0x00068A1E File Offset: 0x00066C1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AttachTargetEntityInfo Clone()
		{
			return new AttachTargetEntityInfo(this);
		}

		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x06002776 RID: 10102 RVA: 0x00068A26 File Offset: 0x00066C26
		// (set) Token: 0x06002777 RID: 10103 RVA: 0x00068A2E File Offset: 0x00066C2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TargetConfigId
		{
			get
			{
				return this.targetConfigId_;
			}
			set
			{
				this.targetConfigId_ = value;
			}
		}

		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x06002778 RID: 10104 RVA: 0x00068A37 File Offset: 0x00066C37
		// (set) Token: 0x06002779 RID: 10105 RVA: 0x00068A3F File Offset: 0x00066C3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Actor
		{
			get
			{
				return this.actor_;
			}
			set
			{
				this.actor_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x0600277A RID: 10106 RVA: 0x00068A52 File Offset: 0x00066C52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AttachTargetEntityInfo);
		}

		// Token: 0x0600277B RID: 10107 RVA: 0x00068A60 File Offset: 0x00066C60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AttachTargetEntityInfo other)
		{
			return other != null && (other == this || (this.TargetConfigId == other.TargetConfigId && !(this.Actor != other.Actor) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600277C RID: 10108 RVA: 0x00068AB0 File Offset: 0x00066CB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TargetConfigId != 0)
			{
				num ^= this.TargetConfigId.GetHashCode();
			}
			if (this.Actor.Length != 0)
			{
				num ^= this.Actor.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600277D RID: 10109 RVA: 0x00068B0A File Offset: 0x00066D0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600277E RID: 10110 RVA: 0x00068B17 File Offset: 0x00066D17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600277F RID: 10111 RVA: 0x00068B20 File Offset: 0x00066D20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TargetConfigId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.TargetConfigId);
			}
			if (this.Actor.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteString(this.Actor);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002780 RID: 10112 RVA: 0x00068B80 File Offset: 0x00066D80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TargetConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TargetConfigId);
			}
			if (this.Actor.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Actor);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002781 RID: 10113 RVA: 0x00068BDC File Offset: 0x00066DDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AttachTargetEntityInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TargetConfigId != 0)
			{
				this.TargetConfigId = other.TargetConfigId;
			}
			if (other.Actor.Length != 0)
			{
				this.Actor = other.Actor;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002782 RID: 10114 RVA: 0x00068C31 File Offset: 0x00066E31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002783 RID: 10115 RVA: 0x00068C3C File Offset: 0x00066E3C
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
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Actor = input.ReadString();
					}
				}
				else
				{
					this.TargetConfigId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040026B2 RID: 9906
		private UnknownFieldSet _unknownFields;

		// Token: 0x040026B3 RID: 9907
		public const int TargetConfigIdFieldNumber = 1;

		// Token: 0x040026B4 RID: 9908
		private int targetConfigId_;

		// Token: 0x040026B5 RID: 9909
		public const int ActorFieldNumber = 2;

		// Token: 0x040026B6 RID: 9910
		private string actor_ = "";
	}
}
