using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001267 RID: 4711
	[NetMessage(EMessageId.SimpleTrackReportRequest)]
	public sealed class SimpleTrackReportRequest : IMessage<SimpleTrackReportRequest>, IMessage, IEquatable<SimpleTrackReportRequest>, IDeepCloneable<SimpleTrackReportRequest>, IBufferMessage
	{
		// Token: 0x0601926D RID: 103021 RVA: 0x003AB352 File Offset: 0x003A9552
		[NullableContext(1)]
		public static SimpleTrackReportRequest Create()
		{
			return new SimpleTrackReportRequest();
		}

		// Token: 0x17005507 RID: 21767
		// (get) Token: 0x0601926E RID: 103022 RVA: 0x003AB359 File Offset: 0x003A9559
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005508 RID: 21768
		// (get) Token: 0x0601926F RID: 103023 RVA: 0x003AB35C File Offset: 0x003A955C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SimpleTrackReportRequest.Descriptor;
			}
		}

		// Token: 0x06019270 RID: 103024 RVA: 0x003AB363 File Offset: 0x003A9563
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SimpleTrackReportRequest()
		{
		}

		// Token: 0x06019271 RID: 103025 RVA: 0x003AB36B File Offset: 0x003A956B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SimpleTrackReportRequest(SimpleTrackReportRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019272 RID: 103026 RVA: 0x003AB384 File Offset: 0x003A9584
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SimpleTrackReportRequest Clone()
		{
			return new SimpleTrackReportRequest(this);
		}

		// Token: 0x06019273 RID: 103027 RVA: 0x003AB38C File Offset: 0x003A958C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SimpleTrackReportRequest);
		}

		// Token: 0x06019274 RID: 103028 RVA: 0x003AB39A File Offset: 0x003A959A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SimpleTrackReportRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06019275 RID: 103029 RVA: 0x003AB3B8 File Offset: 0x003A95B8
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

		// Token: 0x06019276 RID: 103030 RVA: 0x003AB3DE File Offset: 0x003A95DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019277 RID: 103031 RVA: 0x003AB3EB File Offset: 0x003A95EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019278 RID: 103032 RVA: 0x003AB3F4 File Offset: 0x003A95F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019279 RID: 103033 RVA: 0x003AB40C File Offset: 0x003A960C
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

		// Token: 0x0601927A RID: 103034 RVA: 0x003AB432 File Offset: 0x003A9632
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SimpleTrackReportRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601927B RID: 103035 RVA: 0x003AB44F File Offset: 0x003A964F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601927C RID: 103036 RVA: 0x003AB458 File Offset: 0x003A9658
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

		// Token: 0x040094ED RID: 38125
		private UnknownFieldSet _unknownFields;
	}
}
