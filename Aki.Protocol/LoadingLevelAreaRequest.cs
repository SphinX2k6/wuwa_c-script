using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200093F RID: 2367
	[NetMessage(EMessageId.LoadingLevelAreaRequest)]
	public sealed class LoadingLevelAreaRequest : IMessage<LoadingLevelAreaRequest>, IMessage, IEquatable<LoadingLevelAreaRequest>, IDeepCloneable<LoadingLevelAreaRequest>, IBufferMessage
	{
		// Token: 0x0600D08C RID: 53388 RVA: 0x001EAF6E File Offset: 0x001E916E
		[NullableContext(1)]
		public static LoadingLevelAreaRequest Create()
		{
			return new LoadingLevelAreaRequest();
		}

		// Token: 0x17002A22 RID: 10786
		// (get) Token: 0x0600D08D RID: 53389 RVA: 0x001EAF75 File Offset: 0x001E9175
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002A23 RID: 10787
		// (get) Token: 0x0600D08E RID: 53390 RVA: 0x001EAF78 File Offset: 0x001E9178
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LoadingLevelAreaRequest.Descriptor;
			}
		}

		// Token: 0x0600D08F RID: 53391 RVA: 0x001EAF7F File Offset: 0x001E917F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LoadingLevelAreaRequest()
		{
		}

		// Token: 0x0600D090 RID: 53392 RVA: 0x001EAF87 File Offset: 0x001E9187
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LoadingLevelAreaRequest(LoadingLevelAreaRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D091 RID: 53393 RVA: 0x001EAFA0 File Offset: 0x001E91A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LoadingLevelAreaRequest Clone()
		{
			return new LoadingLevelAreaRequest(this);
		}

		// Token: 0x0600D092 RID: 53394 RVA: 0x001EAFA8 File Offset: 0x001E91A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LoadingLevelAreaRequest);
		}

		// Token: 0x0600D093 RID: 53395 RVA: 0x001EAFB6 File Offset: 0x001E91B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LoadingLevelAreaRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600D094 RID: 53396 RVA: 0x001EAFD4 File Offset: 0x001E91D4
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

		// Token: 0x0600D095 RID: 53397 RVA: 0x001EAFFA File Offset: 0x001E91FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D096 RID: 53398 RVA: 0x001EB007 File Offset: 0x001E9207
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D097 RID: 53399 RVA: 0x001EB010 File Offset: 0x001E9210
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D098 RID: 53400 RVA: 0x001EB028 File Offset: 0x001E9228
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

		// Token: 0x0600D099 RID: 53401 RVA: 0x001EB04E File Offset: 0x001E924E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LoadingLevelAreaRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D09A RID: 53402 RVA: 0x001EB06B File Offset: 0x001E926B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D09B RID: 53403 RVA: 0x001EB074 File Offset: 0x001E9274
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

		// Token: 0x040057D2 RID: 22482
		private UnknownFieldSet _unknownFields;
	}
}
