using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000ED9 RID: 3801
	[NetMessage(EMessageId.RegressTrialRoleLvUpRequest)]
	public sealed class RegressTrialRoleLvUpRequest : IMessage<RegressTrialRoleLvUpRequest>, IMessage, IEquatable<RegressTrialRoleLvUpRequest>, IDeepCloneable<RegressTrialRoleLvUpRequest>, IBufferMessage
	{
		// Token: 0x06014665 RID: 83557 RVA: 0x002F77E9 File Offset: 0x002F59E9
		[NullableContext(1)]
		public static RegressTrialRoleLvUpRequest Create()
		{
			return new RegressTrialRoleLvUpRequest();
		}

		// Token: 0x170043DC RID: 17372
		// (get) Token: 0x06014666 RID: 83558 RVA: 0x002F77F0 File Offset: 0x002F59F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170043DD RID: 17373
		// (get) Token: 0x06014667 RID: 83559 RVA: 0x002F77F3 File Offset: 0x002F59F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RegressTrialRoleLvUpRequest.Descriptor;
			}
		}

		// Token: 0x06014668 RID: 83560 RVA: 0x002F77FA File Offset: 0x002F59FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressTrialRoleLvUpRequest()
		{
		}

		// Token: 0x06014669 RID: 83561 RVA: 0x002F7802 File Offset: 0x002F5A02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressTrialRoleLvUpRequest(RegressTrialRoleLvUpRequest other) : this()
		{
			this.trialRoleId_ = other.trialRoleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601466A RID: 83562 RVA: 0x002F7827 File Offset: 0x002F5A27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressTrialRoleLvUpRequest Clone()
		{
			return new RegressTrialRoleLvUpRequest(this);
		}

		// Token: 0x170043DE RID: 17374
		// (get) Token: 0x0601466B RID: 83563 RVA: 0x002F782F File Offset: 0x002F5A2F
		// (set) Token: 0x0601466C RID: 83564 RVA: 0x002F7837 File Offset: 0x002F5A37
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

		// Token: 0x0601466D RID: 83565 RVA: 0x002F7840 File Offset: 0x002F5A40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RegressTrialRoleLvUpRequest);
		}

		// Token: 0x0601466E RID: 83566 RVA: 0x002F784E File Offset: 0x002F5A4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RegressTrialRoleLvUpRequest other)
		{
			return other != null && (other == this || (this.TrialRoleId == other.TrialRoleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601466F RID: 83567 RVA: 0x002F787C File Offset: 0x002F5A7C
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

		// Token: 0x06014670 RID: 83568 RVA: 0x002F78BB File Offset: 0x002F5ABB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014671 RID: 83569 RVA: 0x002F78C8 File Offset: 0x002F5AC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014672 RID: 83570 RVA: 0x002F78D1 File Offset: 0x002F5AD1
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

		// Token: 0x06014673 RID: 83571 RVA: 0x002F7904 File Offset: 0x002F5B04
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

		// Token: 0x06014674 RID: 83572 RVA: 0x002F7942 File Offset: 0x002F5B42
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

		// Token: 0x06014675 RID: 83573 RVA: 0x002F7973 File Offset: 0x002F5B73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014676 RID: 83574 RVA: 0x002F797C File Offset: 0x002F5B7C
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

		// Token: 0x04007C44 RID: 31812
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007C45 RID: 31813
		public const int TrialRoleIdFieldNumber = 5;

		// Token: 0x04007C46 RID: 31814
		private int trialRoleId_;
	}
}
