using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000987 RID: 2439
	[NetMessage(EMessageId.MapTraceInfoRequest)]
	public sealed class MapTraceInfoRequest : IMessage<MapTraceInfoRequest>, IMessage, IEquatable<MapTraceInfoRequest>, IDeepCloneable<MapTraceInfoRequest>, IBufferMessage
	{
		// Token: 0x0600D6B0 RID: 54960 RVA: 0x001F9785 File Offset: 0x001F7985
		[NullableContext(1)]
		public static MapTraceInfoRequest Create()
		{
			return new MapTraceInfoRequest();
		}

		// Token: 0x17002B74 RID: 11124
		// (get) Token: 0x0600D6B1 RID: 54961 RVA: 0x001F978C File Offset: 0x001F798C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002B75 RID: 11125
		// (get) Token: 0x0600D6B2 RID: 54962 RVA: 0x001F978F File Offset: 0x001F798F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MapTraceInfoRequest.Descriptor;
			}
		}

		// Token: 0x0600D6B3 RID: 54963 RVA: 0x001F9796 File Offset: 0x001F7996
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapTraceInfoRequest()
		{
		}

		// Token: 0x0600D6B4 RID: 54964 RVA: 0x001F979E File Offset: 0x001F799E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapTraceInfoRequest(MapTraceInfoRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D6B5 RID: 54965 RVA: 0x001F97B7 File Offset: 0x001F79B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapTraceInfoRequest Clone()
		{
			return new MapTraceInfoRequest(this);
		}

		// Token: 0x0600D6B6 RID: 54966 RVA: 0x001F97BF File Offset: 0x001F79BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MapTraceInfoRequest);
		}

		// Token: 0x0600D6B7 RID: 54967 RVA: 0x001F97CD File Offset: 0x001F79CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MapTraceInfoRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600D6B8 RID: 54968 RVA: 0x001F97EC File Offset: 0x001F79EC
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

		// Token: 0x0600D6B9 RID: 54969 RVA: 0x001F9812 File Offset: 0x001F7A12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D6BA RID: 54970 RVA: 0x001F981F File Offset: 0x001F7A1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D6BB RID: 54971 RVA: 0x001F9828 File Offset: 0x001F7A28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D6BC RID: 54972 RVA: 0x001F9840 File Offset: 0x001F7A40
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

		// Token: 0x0600D6BD RID: 54973 RVA: 0x001F9866 File Offset: 0x001F7A66
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

		// Token: 0x0600D6BE RID: 54974 RVA: 0x001F9883 File Offset: 0x001F7A83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D6BF RID: 54975 RVA: 0x001F988C File Offset: 0x001F7A8C
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

		// Token: 0x04005A0F RID: 23055
		private UnknownFieldSet _unknownFields;
	}
}
