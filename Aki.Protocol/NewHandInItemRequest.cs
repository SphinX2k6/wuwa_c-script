using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B03 RID: 2819
	[NetMessage(EMessageId.NewHandInItemRequest)]
	public sealed class NewHandInItemRequest : IMessage<NewHandInItemRequest>, IMessage, IEquatable<NewHandInItemRequest>, IDeepCloneable<NewHandInItemRequest>, IBufferMessage
	{
		// Token: 0x0600F532 RID: 62770 RVA: 0x0023CA1F File Offset: 0x0023AC1F
		[NullableContext(1)]
		public static NewHandInItemRequest Create()
		{
			return new NewHandInItemRequest();
		}

		// Token: 0x170031EB RID: 12779
		// (get) Token: 0x0600F533 RID: 62771 RVA: 0x0023CA26 File Offset: 0x0023AC26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170031EC RID: 12780
		// (get) Token: 0x0600F534 RID: 62772 RVA: 0x0023CA29 File Offset: 0x0023AC29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewHandInItemRequest.Descriptor;
			}
		}

		// Token: 0x0600F535 RID: 62773 RVA: 0x0023CA30 File Offset: 0x0023AC30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewHandInItemRequest()
		{
		}

		// Token: 0x0600F536 RID: 62774 RVA: 0x0023CA38 File Offset: 0x0023AC38
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

		// Token: 0x0600F537 RID: 62775 RVA: 0x0023CA6B File Offset: 0x0023AC6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewHandInItemRequest Clone()
		{
			return new NewHandInItemRequest(this);
		}

		// Token: 0x170031ED RID: 12781
		// (get) Token: 0x0600F538 RID: 62776 RVA: 0x0023CA73 File Offset: 0x0023AC73
		// (set) Token: 0x0600F539 RID: 62777 RVA: 0x0023CA8B File Offset: 0x0023AC8B
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

		// Token: 0x170031EE RID: 12782
		// (get) Token: 0x0600F53A RID: 62778 RVA: 0x0023CAA1 File Offset: 0x0023ACA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewHandInItemRequest.HandInfosOneofCase HandInfosCase
		{
			get
			{
				return this.handInfosCase_;
			}
		}

		// Token: 0x0600F53B RID: 62779 RVA: 0x0023CAA9 File Offset: 0x0023ACA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearHandInfos()
		{
			this.handInfosCase_ = NewHandInItemRequest.HandInfosOneofCase.None;
			this.handInfos_ = null;
		}

		// Token: 0x0600F53C RID: 62780 RVA: 0x0023CAB9 File Offset: 0x0023ACB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewHandInItemRequest);
		}

		// Token: 0x0600F53D RID: 62781 RVA: 0x0023CAC8 File Offset: 0x0023ACC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewHandInItemRequest other)
		{
			return other != null && (other == this || (object.Equals(this.ProjectionMachine, other.ProjectionMachine) && this.HandInfosCase == other.HandInfosCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F53E RID: 62782 RVA: 0x0023CB18 File Offset: 0x0023AD18
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

		// Token: 0x0600F53F RID: 62783 RVA: 0x0023CB5E File Offset: 0x0023AD5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F540 RID: 62784 RVA: 0x0023CB6B File Offset: 0x0023AD6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F541 RID: 62785 RVA: 0x0023CB74 File Offset: 0x0023AD74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.handInfosCase_ == NewHandInItemRequest.HandInfosOneofCase.ProjectionMachine)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.ProjectionMachine);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F542 RID: 62786 RVA: 0x0023CBA8 File Offset: 0x0023ADA8
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

		// Token: 0x0600F543 RID: 62787 RVA: 0x0023CBE8 File Offset: 0x0023ADE8
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

		// Token: 0x0600F544 RID: 62788 RVA: 0x0023CC3D File Offset: 0x0023AE3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F545 RID: 62789 RVA: 0x0023CC48 File Offset: 0x0023AE48
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

		// Token: 0x040062F9 RID: 25337
		private UnknownFieldSet _unknownFields;

		// Token: 0x040062FA RID: 25338
		public const int ProjectionMachineFieldNumber = 8;

		// Token: 0x040062FB RID: 25339
		private object handInfos_;

		// Token: 0x040062FC RID: 25340
		private NewHandInItemRequest.HandInfosOneofCase handInfosCase_;

		// Token: 0x020018D6 RID: 6358
		public enum HandInfosOneofCase
		{
			// Token: 0x0400CD62 RID: 52578
			None,
			// Token: 0x0400CD63 RID: 52579
			ProjectionMachine = 8
		}
	}
}
