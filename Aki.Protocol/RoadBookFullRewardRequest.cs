using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F5B RID: 3931
	[NetMessage(EMessageId.RoadBookFullRewardRequest)]
	public sealed class RoadBookFullRewardRequest : IMessage<RoadBookFullRewardRequest>, IMessage, IEquatable<RoadBookFullRewardRequest>, IDeepCloneable<RoadBookFullRewardRequest>, IBufferMessage
	{
		// Token: 0x060150C4 RID: 86212 RVA: 0x0030DF7D File Offset: 0x0030C17D
		[NullableContext(1)]
		public static RoadBookFullRewardRequest Create()
		{
			return new RoadBookFullRewardRequest();
		}

		// Token: 0x17004609 RID: 17929
		// (get) Token: 0x060150C5 RID: 86213 RVA: 0x0030DF84 File Offset: 0x0030C184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700460A RID: 17930
		// (get) Token: 0x060150C6 RID: 86214 RVA: 0x0030DF87 File Offset: 0x0030C187
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoadBookFullRewardRequest.Descriptor;
			}
		}

		// Token: 0x060150C7 RID: 86215 RVA: 0x0030DF8E File Offset: 0x0030C18E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoadBookFullRewardRequest()
		{
		}

		// Token: 0x060150C8 RID: 86216 RVA: 0x0030DF96 File Offset: 0x0030C196
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoadBookFullRewardRequest(RoadBookFullRewardRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060150C9 RID: 86217 RVA: 0x0030DFAF File Offset: 0x0030C1AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoadBookFullRewardRequest Clone()
		{
			return new RoadBookFullRewardRequest(this);
		}

		// Token: 0x060150CA RID: 86218 RVA: 0x0030DFB7 File Offset: 0x0030C1B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoadBookFullRewardRequest);
		}

		// Token: 0x060150CB RID: 86219 RVA: 0x0030DFC5 File Offset: 0x0030C1C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoadBookFullRewardRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060150CC RID: 86220 RVA: 0x0030DFE4 File Offset: 0x0030C1E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060150CD RID: 86221 RVA: 0x0030E00A File Offset: 0x0030C20A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060150CE RID: 86222 RVA: 0x0030E017 File Offset: 0x0030C217
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060150CF RID: 86223 RVA: 0x0030E020 File Offset: 0x0030C220
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060150D0 RID: 86224 RVA: 0x0030E038 File Offset: 0x0030C238
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060150D1 RID: 86225 RVA: 0x0030E05E File Offset: 0x0030C25E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoadBookFullRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060150D2 RID: 86226 RVA: 0x0030E07B File Offset: 0x0030C27B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060150D3 RID: 86227 RVA: 0x0030E084 File Offset: 0x0030C284
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
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007F35 RID: 32565
		private UnknownFieldSet _unknownFields;
	}
}
