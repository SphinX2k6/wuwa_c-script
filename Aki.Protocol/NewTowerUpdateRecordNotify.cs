using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B41 RID: 2881
	[NetMessage(EMessageId.NewTowerUpdateRecordNotify)]
	public sealed class NewTowerUpdateRecordNotify : IMessage<NewTowerUpdateRecordNotify>, IMessage, IEquatable<NewTowerUpdateRecordNotify>, IDeepCloneable<NewTowerUpdateRecordNotify>, IBufferMessage
	{
		// Token: 0x0600FA29 RID: 64041 RVA: 0x00247B21 File Offset: 0x00245D21
		[NullableContext(1)]
		public static NewTowerUpdateRecordNotify Create()
		{
			return new NewTowerUpdateRecordNotify();
		}

		// Token: 0x170032FC RID: 13052
		// (get) Token: 0x0600FA2A RID: 64042 RVA: 0x00247B28 File Offset: 0x00245D28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170032FD RID: 13053
		// (get) Token: 0x0600FA2B RID: 64043 RVA: 0x00247B2B File Offset: 0x00245D2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewTowerUpdateRecordNotify.Descriptor;
			}
		}

		// Token: 0x0600FA2C RID: 64044 RVA: 0x00247B32 File Offset: 0x00245D32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerUpdateRecordNotify()
		{
		}

		// Token: 0x0600FA2D RID: 64045 RVA: 0x00247B3A File Offset: 0x00245D3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerUpdateRecordNotify(NewTowerUpdateRecordNotify other) : this()
		{
			this.record_ = ((other.record_ != null) ? other.record_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FA2E RID: 64046 RVA: 0x00247B6F File Offset: 0x00245D6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerUpdateRecordNotify Clone()
		{
			return new NewTowerUpdateRecordNotify(this);
		}

		// Token: 0x170032FE RID: 13054
		// (get) Token: 0x0600FA2F RID: 64047 RVA: 0x00247B77 File Offset: 0x00245D77
		// (set) Token: 0x0600FA30 RID: 64048 RVA: 0x00247B7F File Offset: 0x00245D7F
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

		// Token: 0x0600FA31 RID: 64049 RVA: 0x00247B88 File Offset: 0x00245D88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewTowerUpdateRecordNotify);
		}

		// Token: 0x0600FA32 RID: 64050 RVA: 0x00247B96 File Offset: 0x00245D96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewTowerUpdateRecordNotify other)
		{
			return other != null && (other == this || (object.Equals(this.Record, other.Record) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FA33 RID: 64051 RVA: 0x00247BCC File Offset: 0x00245DCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x0600FA34 RID: 64052 RVA: 0x00247C08 File Offset: 0x00245E08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FA35 RID: 64053 RVA: 0x00247C15 File Offset: 0x00245E15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FA36 RID: 64054 RVA: 0x00247C1E File Offset: 0x00245E1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.record_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.Record);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600FA37 RID: 64055 RVA: 0x00247C50 File Offset: 0x00245E50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x0600FA38 RID: 64056 RVA: 0x00247C90 File Offset: 0x00245E90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewTowerUpdateRecordNotify other)
		{
			if (other == null)
			{
				return;
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

		// Token: 0x0600FA39 RID: 64057 RVA: 0x00247CE4 File Offset: 0x00245EE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FA3A RID: 64058 RVA: 0x00247CF0 File Offset: 0x00245EF0
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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

		// Token: 0x04006483 RID: 25731
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006484 RID: 25732
		public const int RecordFieldNumber = 7;

		// Token: 0x04006485 RID: 25733
		private NewTowerClimbingLevelRecord record_;
	}
}
