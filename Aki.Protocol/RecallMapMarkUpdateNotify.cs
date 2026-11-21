using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EA3 RID: 3747
	[NetMessage(EMessageId.RecallMapMarkUpdateNotify)]
	public sealed class RecallMapMarkUpdateNotify : IMessage<RecallMapMarkUpdateNotify>, IMessage, IEquatable<RecallMapMarkUpdateNotify>, IDeepCloneable<RecallMapMarkUpdateNotify>, IBufferMessage
	{
		// Token: 0x0601422A RID: 82474 RVA: 0x002EE955 File Offset: 0x002ECB55
		[NullableContext(1)]
		public static RecallMapMarkUpdateNotify Create()
		{
			return new RecallMapMarkUpdateNotify();
		}

		// Token: 0x170042FE RID: 17150
		// (get) Token: 0x0601422B RID: 82475 RVA: 0x002EE95C File Offset: 0x002ECB5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170042FF RID: 17151
		// (get) Token: 0x0601422C RID: 82476 RVA: 0x002EE95F File Offset: 0x002ECB5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RecallMapMarkUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0601422D RID: 82477 RVA: 0x002EE966 File Offset: 0x002ECB66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallMapMarkUpdateNotify()
		{
		}

		// Token: 0x0601422E RID: 82478 RVA: 0x002EE96E File Offset: 0x002ECB6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallMapMarkUpdateNotify(RecallMapMarkUpdateNotify other) : this()
		{
			this.markInfo_ = ((other.markInfo_ != null) ? other.markInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601422F RID: 82479 RVA: 0x002EE9A3 File Offset: 0x002ECBA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallMapMarkUpdateNotify Clone()
		{
			return new RecallMapMarkUpdateNotify(this);
		}

		// Token: 0x17004300 RID: 17152
		// (get) Token: 0x06014230 RID: 82480 RVA: 0x002EE9AB File Offset: 0x002ECBAB
		// (set) Token: 0x06014231 RID: 82481 RVA: 0x002EE9B3 File Offset: 0x002ECBB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapMarkShowInfo MarkInfo
		{
			get
			{
				return this.markInfo_;
			}
			set
			{
				this.markInfo_ = value;
			}
		}

		// Token: 0x06014232 RID: 82482 RVA: 0x002EE9BC File Offset: 0x002ECBBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RecallMapMarkUpdateNotify);
		}

		// Token: 0x06014233 RID: 82483 RVA: 0x002EE9CA File Offset: 0x002ECBCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RecallMapMarkUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.MarkInfo, other.MarkInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014234 RID: 82484 RVA: 0x002EEA00 File Offset: 0x002ECC00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.markInfo_ != null)
			{
				num ^= this.MarkInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014235 RID: 82485 RVA: 0x002EEA3C File Offset: 0x002ECC3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014236 RID: 82486 RVA: 0x002EEA49 File Offset: 0x002ECC49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014237 RID: 82487 RVA: 0x002EEA52 File Offset: 0x002ECC52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.markInfo_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.MarkInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014238 RID: 82488 RVA: 0x002EEA84 File Offset: 0x002ECC84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.markInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MarkInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014239 RID: 82489 RVA: 0x002EEAC4 File Offset: 0x002ECCC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RecallMapMarkUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.markInfo_ != null)
			{
				if (this.markInfo_ == null)
				{
					this.MarkInfo = new MapMarkShowInfo();
				}
				this.MarkInfo.MergeFrom(other.MarkInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601423A RID: 82490 RVA: 0x002EEB18 File Offset: 0x002ECD18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601423B RID: 82491 RVA: 0x002EEB24 File Offset: 0x002ECD24
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
				if (num != 34U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.markInfo_ == null)
					{
						this.MarkInfo = new MapMarkShowInfo();
					}
					input.ReadMessage(this.MarkInfo);
				}
			}
		}

		// Token: 0x04007B18 RID: 31512
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007B19 RID: 31513
		public const int MarkInfoFieldNumber = 4;

		// Token: 0x04007B1A RID: 31514
		private MapMarkShowInfo markInfo_;
	}
}
