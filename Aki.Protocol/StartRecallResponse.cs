using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200128F RID: 4751
	[NetMessage(EMessageId.StartRecallResponse)]
	public sealed class StartRecallResponse : IMessage<StartRecallResponse>, IMessage, IEquatable<StartRecallResponse>, IDeepCloneable<StartRecallResponse>, IBufferMessage
	{
		// Token: 0x060194C0 RID: 103616 RVA: 0x003ADB63 File Offset: 0x003ABD63
		[NullableContext(1)]
		public static StartRecallResponse Create()
		{
			return new StartRecallResponse();
		}

		// Token: 0x17005554 RID: 21844
		// (get) Token: 0x060194C1 RID: 103617 RVA: 0x003ADB6A File Offset: 0x003ABD6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005555 RID: 21845
		// (get) Token: 0x060194C2 RID: 103618 RVA: 0x003ADB6D File Offset: 0x003ABD6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StartRecallResponse.Descriptor;
			}
		}

		// Token: 0x060194C3 RID: 103619 RVA: 0x003ADB74 File Offset: 0x003ABD74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartRecallResponse()
		{
		}

		// Token: 0x060194C4 RID: 103620 RVA: 0x003ADB7C File Offset: 0x003ABD7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartRecallResponse(StartRecallResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.canContinue_ = other.canContinue_;
			this.enterInstId_ = other.enterInstId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060194C5 RID: 103621 RVA: 0x003ADBB9 File Offset: 0x003ABDB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartRecallResponse Clone()
		{
			return new StartRecallResponse(this);
		}

		// Token: 0x17005556 RID: 21846
		// (get) Token: 0x060194C6 RID: 103622 RVA: 0x003ADBC1 File Offset: 0x003ABDC1
		// (set) Token: 0x060194C7 RID: 103623 RVA: 0x003ADBC9 File Offset: 0x003ABDC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x17005557 RID: 21847
		// (get) Token: 0x060194C8 RID: 103624 RVA: 0x003ADBD2 File Offset: 0x003ABDD2
		// (set) Token: 0x060194C9 RID: 103625 RVA: 0x003ADBDA File Offset: 0x003ABDDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool CanContinue
		{
			get
			{
				return this.canContinue_;
			}
			set
			{
				this.canContinue_ = value;
			}
		}

		// Token: 0x17005558 RID: 21848
		// (get) Token: 0x060194CA RID: 103626 RVA: 0x003ADBE3 File Offset: 0x003ABDE3
		// (set) Token: 0x060194CB RID: 103627 RVA: 0x003ADBEB File Offset: 0x003ABDEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EnterInstId
		{
			get
			{
				return this.enterInstId_;
			}
			set
			{
				this.enterInstId_ = value;
			}
		}

		// Token: 0x060194CC RID: 103628 RVA: 0x003ADBF4 File Offset: 0x003ABDF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as StartRecallResponse);
		}

		// Token: 0x060194CD RID: 103629 RVA: 0x003ADC04 File Offset: 0x003ABE04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(StartRecallResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.CanContinue == other.CanContinue && this.EnterInstId == other.EnterInstId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060194CE RID: 103630 RVA: 0x003ADC60 File Offset: 0x003ABE60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.CanContinue)
			{
				num ^= this.CanContinue.GetHashCode();
			}
			if (this.EnterInstId != 0)
			{
				num ^= this.EnterInstId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060194CF RID: 103631 RVA: 0x003ADCD7 File Offset: 0x003ABED7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060194D0 RID: 103632 RVA: 0x003ADCE4 File Offset: 0x003ABEE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060194D1 RID: 103633 RVA: 0x003ADCF0 File Offset: 0x003ABEF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CanContinue)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.CanContinue);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.EnterInstId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.EnterInstId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060194D2 RID: 103634 RVA: 0x003ADD68 File Offset: 0x003ABF68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.CanContinue)
			{
				num += 2;
			}
			if (this.EnterInstId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EnterInstId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060194D3 RID: 103635 RVA: 0x003ADDCC File Offset: 0x003ABFCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(StartRecallResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.CanContinue)
			{
				this.CanContinue = other.CanContinue;
			}
			if (other.EnterInstId != 0)
			{
				this.EnterInstId = other.EnterInstId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060194D4 RID: 103636 RVA: 0x003ADE30 File Offset: 0x003AC030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060194D5 RID: 103637 RVA: 0x003ADE3C File Offset: 0x003AC03C
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
					if (num != 88U)
					{
						if (num != 104U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.EnterInstId = input.ReadInt32();
						}
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.CanContinue = input.ReadBool();
				}
			}
		}

		// Token: 0x040094B8 RID: 38072
		private UnknownFieldSet _unknownFields;

		// Token: 0x040094B9 RID: 38073
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x040094BA RID: 38074
		private ErrorCode errorCode_;

		// Token: 0x040094BB RID: 38075
		public const int CanContinueFieldNumber = 6;

		// Token: 0x040094BC RID: 38076
		private bool canContinue_;

		// Token: 0x040094BD RID: 38077
		public const int EnterInstIdFieldNumber = 13;

		// Token: 0x040094BE RID: 38078
		private int enterInstId_;
	}
}
