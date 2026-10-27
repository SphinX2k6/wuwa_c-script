using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EE9 RID: 3817
	[NetMessage(EMessageId.RegressTrialRoleLvUpRequest)]
	public sealed class RegressTrialRoleLvUpRequest : IMessage<RegressTrialRoleLvUpRequest>, IMessage, IEquatable<RegressTrialRoleLvUpRequest>, IDeepCloneable<RegressTrialRoleLvUpRequest>, IBufferMessage
	{
		// Token: 0x0601474A RID: 83786 RVA: 0x002F8E9D File Offset: 0x002F709D
		[NullableContext(1)]
		public static RegressTrialRoleLvUpRequest Create()
		{
			return new RegressTrialRoleLvUpRequest();
		}

		// Token: 0x17004406 RID: 17414
		// (get) Token: 0x0601474B RID: 83787 RVA: 0x002F8EA4 File Offset: 0x002F70A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004407 RID: 17415
		// (get) Token: 0x0601474C RID: 83788 RVA: 0x002F8EA7 File Offset: 0x002F70A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RegressTrialRoleLvUpRequest.Descriptor;
			}
		}

		// Token: 0x0601474D RID: 83789 RVA: 0x002F8EAE File Offset: 0x002F70AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressTrialRoleLvUpRequest()
		{
		}

		// Token: 0x0601474E RID: 83790 RVA: 0x002F8EB6 File Offset: 0x002F70B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressTrialRoleLvUpRequest(RegressTrialRoleLvUpRequest other) : this()
		{
			this.trialRoleId_ = other.trialRoleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601474F RID: 83791 RVA: 0x002F8EDB File Offset: 0x002F70DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressTrialRoleLvUpRequest Clone()
		{
			return new RegressTrialRoleLvUpRequest(this);
		}

		// Token: 0x17004408 RID: 17416
		// (get) Token: 0x06014750 RID: 83792 RVA: 0x002F8EE3 File Offset: 0x002F70E3
		// (set) Token: 0x06014751 RID: 83793 RVA: 0x002F8EEB File Offset: 0x002F70EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TrialRoleId
		{
			get
			{
				return this.trialRoleId_;
			}
			set
			{
				this.trialRoleId_ = value;
			}
		}

		// Token: 0x06014752 RID: 83794 RVA: 0x002F8EF4 File Offset: 0x002F70F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RegressTrialRoleLvUpRequest);
		}

		// Token: 0x06014753 RID: 83795 RVA: 0x002F8F02 File Offset: 0x002F7102
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RegressTrialRoleLvUpRequest other)
		{
			return other != null && (other == this || (this.TrialRoleId == other.TrialRoleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014754 RID: 83796 RVA: 0x002F8F30 File Offset: 0x002F7130
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TrialRoleId != 0)
			{
				num ^= this.TrialRoleId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014755 RID: 83797 RVA: 0x002F8F6F File Offset: 0x002F716F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014756 RID: 83798 RVA: 0x002F8F7C File Offset: 0x002F717C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014757 RID: 83799 RVA: 0x002F8F85 File Offset: 0x002F7185
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TrialRoleId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.TrialRoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014758 RID: 83800 RVA: 0x002F8FB8 File Offset: 0x002F71B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TrialRoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TrialRoleId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014759 RID: 83801 RVA: 0x002F8FF6 File Offset: 0x002F71F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RegressTrialRoleLvUpRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TrialRoleId != 0)
			{
				this.TrialRoleId = other.TrialRoleId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601475A RID: 83802 RVA: 0x002F9027 File Offset: 0x002F7227
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601475B RID: 83803 RVA: 0x002F9030 File Offset: 0x002F7230
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.TrialRoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007C1A RID: 31770
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007C1B RID: 31771
		public const int TrialRoleIdFieldNumber = 6;

		// Token: 0x04007C1C RID: 31772
		private int trialRoleId_;
	}
}
