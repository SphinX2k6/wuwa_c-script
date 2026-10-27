using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EE5 RID: 3813
	[NetMessage(EMessageId.RegressSetCurUseTrialRoleRequest)]
	public sealed class RegressSetCurUseTrialRoleRequest : IMessage<RegressSetCurUseTrialRoleRequest>, IMessage, IEquatable<RegressSetCurUseTrialRoleRequest>, IDeepCloneable<RegressSetCurUseTrialRoleRequest>, IBufferMessage
	{
		// Token: 0x060146F6 RID: 83702 RVA: 0x002F82BD File Offset: 0x002F64BD
		[NullableContext(1)]
		public static RegressSetCurUseTrialRoleRequest Create()
		{
			return new RegressSetCurUseTrialRoleRequest();
		}

		// Token: 0x170043F4 RID: 17396
		// (get) Token: 0x060146F7 RID: 83703 RVA: 0x002F82C4 File Offset: 0x002F64C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170043F5 RID: 17397
		// (get) Token: 0x060146F8 RID: 83704 RVA: 0x002F82C7 File Offset: 0x002F64C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RegressSetCurUseTrialRoleRequest.Descriptor;
			}
		}

		// Token: 0x060146F9 RID: 83705 RVA: 0x002F82CE File Offset: 0x002F64CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressSetCurUseTrialRoleRequest()
		{
		}

		// Token: 0x060146FA RID: 83706 RVA: 0x002F82D6 File Offset: 0x002F64D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressSetCurUseTrialRoleRequest(RegressSetCurUseTrialRoleRequest other) : this()
		{
			this.trialRoleId_ = other.trialRoleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060146FB RID: 83707 RVA: 0x002F82FB File Offset: 0x002F64FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressSetCurUseTrialRoleRequest Clone()
		{
			return new RegressSetCurUseTrialRoleRequest(this);
		}

		// Token: 0x170043F6 RID: 17398
		// (get) Token: 0x060146FC RID: 83708 RVA: 0x002F8303 File Offset: 0x002F6503
		// (set) Token: 0x060146FD RID: 83709 RVA: 0x002F830B File Offset: 0x002F650B
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

		// Token: 0x060146FE RID: 83710 RVA: 0x002F8314 File Offset: 0x002F6514
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RegressSetCurUseTrialRoleRequest);
		}

		// Token: 0x060146FF RID: 83711 RVA: 0x002F8322 File Offset: 0x002F6522
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RegressSetCurUseTrialRoleRequest other)
		{
			return other != null && (other == this || (this.TrialRoleId == other.TrialRoleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014700 RID: 83712 RVA: 0x002F8350 File Offset: 0x002F6550
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

		// Token: 0x06014701 RID: 83713 RVA: 0x002F838F File Offset: 0x002F658F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014702 RID: 83714 RVA: 0x002F839C File Offset: 0x002F659C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014703 RID: 83715 RVA: 0x002F83A5 File Offset: 0x002F65A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TrialRoleId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.TrialRoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014704 RID: 83716 RVA: 0x002F83D8 File Offset: 0x002F65D8
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

		// Token: 0x06014705 RID: 83717 RVA: 0x002F8416 File Offset: 0x002F6616
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RegressSetCurUseTrialRoleRequest other)
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

		// Token: 0x06014706 RID: 83718 RVA: 0x002F8447 File Offset: 0x002F6647
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014707 RID: 83719 RVA: 0x002F8450 File Offset: 0x002F6650
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
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.TrialRoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007C02 RID: 31746
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007C03 RID: 31747
		public const int TrialRoleIdFieldNumber = 5;

		// Token: 0x04007C04 RID: 31748
		private int trialRoleId_;
	}
}
