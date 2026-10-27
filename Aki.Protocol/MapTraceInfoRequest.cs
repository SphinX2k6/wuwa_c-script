using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000998 RID: 2456
	[NetMessage(EMessageId.MapTraceInfoRequest)]
	public sealed class MapTraceInfoRequest : IMessage<MapTraceInfoRequest>, IMessage, IEquatable<MapTraceInfoRequest>, IDeepCloneable<MapTraceInfoRequest>, IBufferMessage
	{
		// Token: 0x0600D7CA RID: 55242 RVA: 0x001FB975 File Offset: 0x001F9B75
		[NullableContext(1)]
		public static MapTraceInfoRequest Create()
		{
			return new MapTraceInfoRequest();
		}

		// Token: 0x17002BB2 RID: 11186
		// (get) Token: 0x0600D7CB RID: 55243 RVA: 0x001FB97C File Offset: 0x001F9B7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002BB3 RID: 11187
		// (get) Token: 0x0600D7CC RID: 55244 RVA: 0x001FB97F File Offset: 0x001F9B7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MapTraceInfoRequest.Descriptor;
			}
		}

		// Token: 0x0600D7CD RID: 55245 RVA: 0x001FB986 File Offset: 0x001F9B86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapTraceInfoRequest()
		{
		}

		// Token: 0x0600D7CE RID: 55246 RVA: 0x001FB98E File Offset: 0x001F9B8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapTraceInfoRequest(MapTraceInfoRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D7CF RID: 55247 RVA: 0x001FB9A7 File Offset: 0x001F9BA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapTraceInfoRequest Clone()
		{
			return new MapTraceInfoRequest(this);
		}

		// Token: 0x0600D7D0 RID: 55248 RVA: 0x001FB9AF File Offset: 0x001F9BAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MapTraceInfoRequest);
		}

		// Token: 0x0600D7D1 RID: 55249 RVA: 0x001FB9BD File Offset: 0x001F9BBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MapTraceInfoRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600D7D2 RID: 55250 RVA: 0x001FB9DC File Offset: 0x001F9BDC
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

		// Token: 0x0600D7D3 RID: 55251 RVA: 0x001FBA02 File Offset: 0x001F9C02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D7D4 RID: 55252 RVA: 0x001FBA0F File Offset: 0x001F9C0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D7D5 RID: 55253 RVA: 0x001FBA18 File Offset: 0x001F9C18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D7D6 RID: 55254 RVA: 0x001FBA30 File Offset: 0x001F9C30
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

		// Token: 0x0600D7D7 RID: 55255 RVA: 0x001FBA56 File Offset: 0x001F9C56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MapTraceInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D7D8 RID: 55256 RVA: 0x001FBA73 File Offset: 0x001F9C73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D7D9 RID: 55257 RVA: 0x001FBA7C File Offset: 0x001F9C7C
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

		// Token: 0x04005A06 RID: 23046
		private UnknownFieldSet _unknownFields;
	}
}
