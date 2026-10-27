using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B14 RID: 2836
	[NetMessage(EMessageId.NewHandInItemRequest)]
	public sealed class NewHandInItemRequest : IMessage<NewHandInItemRequest>, IMessage, IEquatable<NewHandInItemRequest>, IDeepCloneable<NewHandInItemRequest>, IBufferMessage
	{
		// Token: 0x0600F64C RID: 63052 RVA: 0x0023EC2B File Offset: 0x0023CE2B
		[NullableContext(1)]
		public static NewHandInItemRequest Create()
		{
			return new NewHandInItemRequest();
		}

		// Token: 0x17003229 RID: 12841
		// (get) Token: 0x0600F64D RID: 63053 RVA: 0x0023EC32 File Offset: 0x0023CE32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700322A RID: 12842
		// (get) Token: 0x0600F64E RID: 63054 RVA: 0x0023EC35 File Offset: 0x0023CE35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewHandInItemRequest.Descriptor;
			}
		}

		// Token: 0x0600F64F RID: 63055 RVA: 0x0023EC3C File Offset: 0x0023CE3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewHandInItemRequest()
		{
		}

		// Token: 0x0600F650 RID: 63056 RVA: 0x0023EC44 File Offset: 0x0023CE44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewHandInItemRequest(NewHandInItemRequest other) : this()
		{
			if (other.HandInfosCase == NewHandInItemRequest.HandInfosOneofCase.ProjectionMachine)
			{
				this.ProjectionMachine = other.ProjectionMachine.Clone();
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F651 RID: 63057 RVA: 0x0023EC77 File Offset: 0x0023CE77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewHandInItemRequest Clone()
		{
			return new NewHandInItemRequest(this);
		}

		// Token: 0x1700322B RID: 12843
		// (get) Token: 0x0600F652 RID: 63058 RVA: 0x0023EC7F File Offset: 0x0023CE7F
		// (set) Token: 0x0600F653 RID: 63059 RVA: 0x0023EC97 File Offset: 0x0023CE97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewHandInItemsProjectionMachinePb ProjectionMachine
		{
			get
			{
				if (this.handInfosCase_ != NewHandInItemRequest.HandInfosOneofCase.ProjectionMachine)
				{
					return null;
				}
				return (NewHandInItemsProjectionMachinePb)this.handInfos_;
			}
			set
			{
				this.handInfos_ = value;
				this.handInfosCase_ = ((value == null) ? NewHandInItemRequest.HandInfosOneofCase.None : NewHandInItemRequest.HandInfosOneofCase.ProjectionMachine);
			}
		}

		// Token: 0x1700322C RID: 12844
		// (get) Token: 0x0600F654 RID: 63060 RVA: 0x0023ECAD File Offset: 0x0023CEAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewHandInItemRequest.HandInfosOneofCase HandInfosCase
		{
			get
			{
				return this.handInfosCase_;
			}
		}

		// Token: 0x0600F655 RID: 63061 RVA: 0x0023ECB5 File Offset: 0x0023CEB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearHandInfos()
		{
			this.handInfosCase_ = NewHandInItemRequest.HandInfosOneofCase.None;
			this.handInfos_ = null;
		}

		// Token: 0x0600F656 RID: 63062 RVA: 0x0023ECC5 File Offset: 0x0023CEC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewHandInItemRequest);
		}

		// Token: 0x0600F657 RID: 63063 RVA: 0x0023ECD4 File Offset: 0x0023CED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewHandInItemRequest other)
		{
			return other != null && (other == this || (object.Equals(this.ProjectionMachine, other.ProjectionMachine) && this.HandInfosCase == other.HandInfosCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F658 RID: 63064 RVA: 0x0023ED24 File Offset: 0x0023CF24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.handInfosCase_ == NewHandInItemRequest.HandInfosOneofCase.ProjectionMachine)
			{
				num ^= this.ProjectionMachine.GetHashCode();
			}
			num ^= (int)this.handInfosCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F659 RID: 63065 RVA: 0x0023ED6A File Offset: 0x0023CF6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F65A RID: 63066 RVA: 0x0023ED77 File Offset: 0x0023CF77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F65B RID: 63067 RVA: 0x0023ED80 File Offset: 0x0023CF80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.handInfosCase_ == NewHandInItemRequest.HandInfosOneofCase.ProjectionMachine)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.ProjectionMachine);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F65C RID: 63068 RVA: 0x0023EDB4 File Offset: 0x0023CFB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.handInfosCase_ == NewHandInItemRequest.HandInfosOneofCase.ProjectionMachine)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ProjectionMachine);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F65D RID: 63069 RVA: 0x0023EDF4 File Offset: 0x0023CFF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewHandInItemRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.HandInfosCase == NewHandInItemRequest.HandInfosOneofCase.ProjectionMachine)
			{
				if (this.ProjectionMachine == null)
				{
					this.ProjectionMachine = new NewHandInItemsProjectionMachinePb();
				}
				this.ProjectionMachine.MergeFrom(other.ProjectionMachine);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F65E RID: 63070 RVA: 0x0023EE49 File Offset: 0x0023D049
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F65F RID: 63071 RVA: 0x0023EE54 File Offset: 0x0023D054
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
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					NewHandInItemsProjectionMachinePb newHandInItemsProjectionMachinePb = new NewHandInItemsProjectionMachinePb();
					if (this.handInfosCase_ == NewHandInItemRequest.HandInfosOneofCase.ProjectionMachine)
					{
						newHandInItemsProjectionMachinePb.MergeFrom(this.ProjectionMachine);
					}
					input.ReadMessage(newHandInItemsProjectionMachinePb);
					this.ProjectionMachine = newHandInItemsProjectionMachinePb;
				}
			}
		}

		// Token: 0x040062F0 RID: 25328
		private UnknownFieldSet _unknownFields;

		// Token: 0x040062F1 RID: 25329
		public const int ProjectionMachineFieldNumber = 1;

		// Token: 0x040062F2 RID: 25330
		private object handInfos_;

		// Token: 0x040062F3 RID: 25331
		private NewHandInItemRequest.HandInfosOneofCase handInfosCase_;

		// Token: 0x0200185E RID: 6238
		public enum HandInfosOneofCase
		{
			// Token: 0x0400C837 RID: 51255
			None,
			// Token: 0x0400C838 RID: 51256
			ProjectionMachine
		}
	}
}
