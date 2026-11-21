using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001455 RID: 5205
	[NetMessage(EMessageId.TrackMoonEntrustDataRequest)]
	public sealed class TrackMoonEntrustDataRequest : IMessage<TrackMoonEntrustDataRequest>, IMessage, IEquatable<TrackMoonEntrustDataRequest>, IDeepCloneable<TrackMoonEntrustDataRequest>, IBufferMessage
	{
		// Token: 0x0601BA42 RID: 113218 RVA: 0x00403D3B File Offset: 0x00401F3B
		[NullableContext(1)]
		public static TrackMoonEntrustDataRequest Create()
		{
			return new TrackMoonEntrustDataRequest();
		}

		// Token: 0x17005D89 RID: 23945
		// (get) Token: 0x0601BA43 RID: 113219 RVA: 0x00403D42 File Offset: 0x00401F42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005D8A RID: 23946
		// (get) Token: 0x0601BA44 RID: 113220 RVA: 0x00403D45 File Offset: 0x00401F45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrackMoonEntrustDataRequest.Descriptor;
			}
		}

		// Token: 0x0601BA45 RID: 113221 RVA: 0x00403D4C File Offset: 0x00401F4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonEntrustDataRequest()
		{
		}

		// Token: 0x0601BA46 RID: 113222 RVA: 0x00403D54 File Offset: 0x00401F54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonEntrustDataRequest(TrackMoonEntrustDataRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BA47 RID: 113223 RVA: 0x00403D6D File Offset: 0x00401F6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonEntrustDataRequest Clone()
		{
			return new TrackMoonEntrustDataRequest(this);
		}

		// Token: 0x0601BA48 RID: 113224 RVA: 0x00403D75 File Offset: 0x00401F75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrackMoonEntrustDataRequest);
		}

		// Token: 0x0601BA49 RID: 113225 RVA: 0x00403D83 File Offset: 0x00401F83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrackMoonEntrustDataRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601BA4A RID: 113226 RVA: 0x00403DA4 File Offset: 0x00401FA4
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

		// Token: 0x0601BA4B RID: 113227 RVA: 0x00403DCA File Offset: 0x00401FCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BA4C RID: 113228 RVA: 0x00403DD7 File Offset: 0x00401FD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BA4D RID: 113229 RVA: 0x00403DE0 File Offset: 0x00401FE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BA4E RID: 113230 RVA: 0x00403DF8 File Offset: 0x00401FF8
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

		// Token: 0x0601BA4F RID: 113231 RVA: 0x00403E1E File Offset: 0x0040201E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrackMoonEntrustDataRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601BA50 RID: 113232 RVA: 0x00403E3B File Offset: 0x0040203B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BA51 RID: 113233 RVA: 0x00403E44 File Offset: 0x00402044
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

		// Token: 0x0400A08F RID: 41103
		private UnknownFieldSet _unknownFields;
	}
}
