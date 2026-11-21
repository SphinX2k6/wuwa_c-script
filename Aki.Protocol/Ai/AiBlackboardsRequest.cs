using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.Ai
{
	// Token: 0x02001724 RID: 5924
	[NetMessage(EMessageId.AiBlackboardsRequest)]
	public sealed class AiBlackboardsRequest : IMessage<AiBlackboardsRequest>, IMessage, IEquatable<AiBlackboardsRequest>, IDeepCloneable<AiBlackboardsRequest>, IBufferMessage
	{
		// Token: 0x0601DBD0 RID: 121808 RVA: 0x0045CBF9 File Offset: 0x0045ADF9
		[NullableContext(1)]
		public static AiBlackboardsRequest Create()
		{
			return new AiBlackboardsRequest();
		}

		// Token: 0x17006542 RID: 25922
		// (get) Token: 0x0601DBD1 RID: 121809 RVA: 0x0045CC00 File Offset: 0x0045AE00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006543 RID: 25923
		// (get) Token: 0x0601DBD2 RID: 121810 RVA: 0x0045CC03 File Offset: 0x0045AE03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AiBlackboardsRequest.Descriptor;
			}
		}

		// Token: 0x0601DBD3 RID: 121811 RVA: 0x0045CC0A File Offset: 0x0045AE0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiBlackboardsRequest()
		{
		}

		// Token: 0x0601DBD4 RID: 121812 RVA: 0x0045CC1D File Offset: 0x0045AE1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiBlackboardsRequest(AiBlackboardsRequest other) : this()
		{
			this.aiBlackboards_ = other.aiBlackboards_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601DBD5 RID: 121813 RVA: 0x0045CC47 File Offset: 0x0045AE47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiBlackboardsRequest Clone()
		{
			return new AiBlackboardsRequest(this);
		}

		// Token: 0x17006544 RID: 25924
		// (get) Token: 0x0601DBD6 RID: 121814 RVA: 0x0045CC4F File Offset: 0x0045AE4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BlackboardParam> AiBlackboards
		{
			get
			{
				return this.aiBlackboards_;
			}
		}

		// Token: 0x0601DBD7 RID: 121815 RVA: 0x0045CC57 File Offset: 0x0045AE57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AiBlackboardsRequest);
		}

		// Token: 0x0601DBD8 RID: 121816 RVA: 0x0045CC65 File Offset: 0x0045AE65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AiBlackboardsRequest other)
		{
			return other != null && (other == this || (this.aiBlackboards_.Equals(other.aiBlackboards_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601DBD9 RID: 121817 RVA: 0x0045CC98 File Offset: 0x0045AE98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.aiBlackboards_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601DBDA RID: 121818 RVA: 0x0045CCCC File Offset: 0x0045AECC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601DBDB RID: 121819 RVA: 0x0045CCD9 File Offset: 0x0045AED9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601DBDC RID: 121820 RVA: 0x0045CCE2 File Offset: 0x0045AEE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.aiBlackboards_.WriteTo(ref output, AiBlackboardsRequest._repeated_aiBlackboards_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601DBDD RID: 121821 RVA: 0x0045CD0C File Offset: 0x0045AF0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.aiBlackboards_.CalculateSize(AiBlackboardsRequest._repeated_aiBlackboards_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601DBDE RID: 121822 RVA: 0x0045CD45 File Offset: 0x0045AF45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AiBlackboardsRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.aiBlackboards_.Add(other.aiBlackboards_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601DBDF RID: 121823 RVA: 0x0045CD73 File Offset: 0x0045AF73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601DBE0 RID: 121824 RVA: 0x0045CD7C File Offset: 0x0045AF7C
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
				if (num != 82U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.aiBlackboards_.AddEntriesFrom(ref input, AiBlackboardsRequest._repeated_aiBlackboards_codec);
				}
			}
		}

		// Token: 0x0400C950 RID: 51536
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C951 RID: 51537
		public const int AiBlackboardsFieldNumber = 10;

		// Token: 0x0400C952 RID: 51538
		private static readonly FieldCodec<BlackboardParam> _repeated_aiBlackboards_codec = FieldCodec.ForMessage<BlackboardParam>(82U, BlackboardParam.Parser);

		// Token: 0x0400C953 RID: 51539
		private readonly RepeatedField<BlackboardParam> aiBlackboards_ = new RepeatedField<BlackboardParam>();
	}
}
