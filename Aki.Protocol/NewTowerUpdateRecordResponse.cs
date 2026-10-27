using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B54 RID: 2900
	[NetMessage(EMessageId.NewTowerUpdateRecordResponse)]
	public sealed class NewTowerUpdateRecordResponse : IMessage<NewTowerUpdateRecordResponse>, IMessage, IEquatable<NewTowerUpdateRecordResponse>, IDeepCloneable<NewTowerUpdateRecordResponse>, IBufferMessage
	{
		// Token: 0x0600FB67 RID: 64359 RVA: 0x0024A135 File Offset: 0x00248335
		[NullableContext(1)]
		public static NewTowerUpdateRecordResponse Create()
		{
			return new NewTowerUpdateRecordResponse();
		}

		// Token: 0x17003340 RID: 13120
		// (get) Token: 0x0600FB68 RID: 64360 RVA: 0x0024A13C File Offset: 0x0024833C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003341 RID: 13121
		// (get) Token: 0x0600FB69 RID: 64361 RVA: 0x0024A13F File Offset: 0x0024833F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewTowerUpdateRecordResponse.Descriptor;
			}
		}

		// Token: 0x0600FB6A RID: 64362 RVA: 0x0024A146 File Offset: 0x00248346
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerUpdateRecordResponse()
		{
		}

		// Token: 0x0600FB6B RID: 64363 RVA: 0x0024A150 File Offset: 0x00248350
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerUpdateRecordResponse(NewTowerUpdateRecordResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.record_ = ((other.record_ != null) ? other.record_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FB6C RID: 64364 RVA: 0x0024A19C File Offset: 0x0024839C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerUpdateRecordResponse Clone()
		{
			return new NewTowerUpdateRecordResponse(this);
		}

		// Token: 0x17003342 RID: 13122
		// (get) Token: 0x0600FB6D RID: 64365 RVA: 0x0024A1A4 File Offset: 0x002483A4
		// (set) Token: 0x0600FB6E RID: 64366 RVA: 0x0024A1AC File Offset: 0x002483AC
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

		// Token: 0x17003343 RID: 13123
		// (get) Token: 0x0600FB6F RID: 64367 RVA: 0x0024A1B5 File Offset: 0x002483B5
		// (set) Token: 0x0600FB70 RID: 64368 RVA: 0x0024A1BD File Offset: 0x002483BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerClimbingLevelRecord Record
		{
			get
			{
				return this.record_;
			}
			set
			{
				this.record_ = value;
			}
		}

		// Token: 0x0600FB71 RID: 64369 RVA: 0x0024A1C6 File Offset: 0x002483C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewTowerUpdateRecordResponse);
		}

		// Token: 0x0600FB72 RID: 64370 RVA: 0x0024A1D4 File Offset: 0x002483D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewTowerUpdateRecordResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.Record, other.Record) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FB73 RID: 64371 RVA: 0x0024A224 File Offset: 0x00248424
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.record_ != null)
			{
				num ^= this.Record.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600FB74 RID: 64372 RVA: 0x0024A27F File Offset: 0x0024847F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FB75 RID: 64373 RVA: 0x0024A28C File Offset: 0x0024848C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FB76 RID: 64374 RVA: 0x0024A298 File Offset: 0x00248498
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.record_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.Record);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600FB77 RID: 64375 RVA: 0x0024A2F4 File Offset: 0x002484F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.record_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Record);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600FB78 RID: 64376 RVA: 0x0024A34C File Offset: 0x0024854C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewTowerUpdateRecordResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.record_ != null)
			{
				if (this.record_ == null)
				{
					this.Record = new NewTowerClimbingLevelRecord();
				}
				this.Record.MergeFrom(other.Record);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600FB79 RID: 64377 RVA: 0x0024A3B4 File Offset: 0x002485B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FB7A RID: 64378 RVA: 0x0024A3C0 File Offset: 0x002485C0
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
				if (num != 58U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					if (this.record_ == null)
					{
						this.Record = new NewTowerClimbingLevelRecord();
					}
					input.ReadMessage(this.Record);
				}
			}
		}

		// Token: 0x04006480 RID: 25728
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006481 RID: 25729
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x04006482 RID: 25730
		private ErrorCode errorCode_;

		// Token: 0x04006483 RID: 25731
		public const int RecordFieldNumber = 7;

		// Token: 0x04006484 RID: 25732
		private NewTowerClimbingLevelRecord record_;
	}
}
