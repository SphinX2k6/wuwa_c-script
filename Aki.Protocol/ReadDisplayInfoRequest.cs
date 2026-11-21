using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E88 RID: 3720
	[NetMessage(EMessageId.ReadDisplayInfoRequest)]
	public sealed class ReadDisplayInfoRequest : IMessage<ReadDisplayInfoRequest>, IMessage, IEquatable<ReadDisplayInfoRequest>, IDeepCloneable<ReadDisplayInfoRequest>, IBufferMessage
	{
		// Token: 0x06014009 RID: 81929 RVA: 0x002EA245 File Offset: 0x002E8445
		[NullableContext(1)]
		public static ReadDisplayInfoRequest Create()
		{
			return new ReadDisplayInfoRequest();
		}

		// Token: 0x1700428D RID: 17037
		// (get) Token: 0x0601400A RID: 81930 RVA: 0x002EA24C File Offset: 0x002E844C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700428E RID: 17038
		// (get) Token: 0x0601400B RID: 81931 RVA: 0x002EA24F File Offset: 0x002E844F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ReadDisplayInfoRequest.Descriptor;
			}
		}

		// Token: 0x0601400C RID: 81932 RVA: 0x002EA256 File Offset: 0x002E8456
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReadDisplayInfoRequest()
		{
		}

		// Token: 0x0601400D RID: 81933 RVA: 0x002EA25E File Offset: 0x002E845E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReadDisplayInfoRequest(ReadDisplayInfoRequest other) : this()
		{
			this.displayId_ = other.displayId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601400E RID: 81934 RVA: 0x002EA283 File Offset: 0x002E8483
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReadDisplayInfoRequest Clone()
		{
			return new ReadDisplayInfoRequest(this);
		}

		// Token: 0x1700428F RID: 17039
		// (get) Token: 0x0601400F RID: 81935 RVA: 0x002EA28B File Offset: 0x002E848B
		// (set) Token: 0x06014010 RID: 81936 RVA: 0x002EA293 File Offset: 0x002E8493
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DisplayId
		{
			get
			{
				return this.displayId_;
			}
			set
			{
				this.displayId_ = value;
			}
		}

		// Token: 0x06014011 RID: 81937 RVA: 0x002EA29C File Offset: 0x002E849C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ReadDisplayInfoRequest);
		}

		// Token: 0x06014012 RID: 81938 RVA: 0x002EA2AA File Offset: 0x002E84AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ReadDisplayInfoRequest other)
		{
			return other != null && (other == this || (this.DisplayId == other.DisplayId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014013 RID: 81939 RVA: 0x002EA2D8 File Offset: 0x002E84D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DisplayId != 0)
			{
				num ^= this.DisplayId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014014 RID: 81940 RVA: 0x002EA317 File Offset: 0x002E8517
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014015 RID: 81941 RVA: 0x002EA324 File Offset: 0x002E8524
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014016 RID: 81942 RVA: 0x002EA32D File Offset: 0x002E852D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DisplayId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.DisplayId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014017 RID: 81943 RVA: 0x002EA360 File Offset: 0x002E8560
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DisplayId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DisplayId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014018 RID: 81944 RVA: 0x002EA39E File Offset: 0x002E859E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ReadDisplayInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DisplayId != 0)
			{
				this.DisplayId = other.DisplayId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014019 RID: 81945 RVA: 0x002EA3CF File Offset: 0x002E85CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601401A RID: 81946 RVA: 0x002EA3D8 File Offset: 0x002E85D8
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.DisplayId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007A84 RID: 31364
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007A85 RID: 31365
		public const int DisplayIdFieldNumber = 1;

		// Token: 0x04007A86 RID: 31366
		private int displayId_;
	}
}
