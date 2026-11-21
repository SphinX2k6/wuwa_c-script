using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000956 RID: 2390
	[NetMessage(EMessageId.LowMemoryChangeSceneFinishRequest)]
	public sealed class LowMemoryChangeSceneFinishRequest : IMessage<LowMemoryChangeSceneFinishRequest>, IMessage, IEquatable<LowMemoryChangeSceneFinishRequest>, IDeepCloneable<LowMemoryChangeSceneFinishRequest>, IBufferMessage
	{
		// Token: 0x0600D2EA RID: 53994 RVA: 0x001F197D File Offset: 0x001EFB7D
		[NullableContext(1)]
		public static LowMemoryChangeSceneFinishRequest Create()
		{
			return new LowMemoryChangeSceneFinishRequest();
		}

		// Token: 0x17002AB4 RID: 10932
		// (get) Token: 0x0600D2EB RID: 53995 RVA: 0x001F1984 File Offset: 0x001EFB84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002AB5 RID: 10933
		// (get) Token: 0x0600D2EC RID: 53996 RVA: 0x001F1987 File Offset: 0x001EFB87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LowMemoryChangeSceneFinishRequest.Descriptor;
			}
		}

		// Token: 0x0600D2ED RID: 53997 RVA: 0x001F198E File Offset: 0x001EFB8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LowMemoryChangeSceneFinishRequest()
		{
		}

		// Token: 0x0600D2EE RID: 53998 RVA: 0x001F1996 File Offset: 0x001EFB96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LowMemoryChangeSceneFinishRequest(LowMemoryChangeSceneFinishRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D2EF RID: 53999 RVA: 0x001F19AF File Offset: 0x001EFBAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LowMemoryChangeSceneFinishRequest Clone()
		{
			return new LowMemoryChangeSceneFinishRequest(this);
		}

		// Token: 0x0600D2F0 RID: 54000 RVA: 0x001F19B7 File Offset: 0x001EFBB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LowMemoryChangeSceneFinishRequest);
		}

		// Token: 0x0600D2F1 RID: 54001 RVA: 0x001F19C5 File Offset: 0x001EFBC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LowMemoryChangeSceneFinishRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600D2F2 RID: 54002 RVA: 0x001F19E4 File Offset: 0x001EFBE4
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

		// Token: 0x0600D2F3 RID: 54003 RVA: 0x001F1A0A File Offset: 0x001EFC0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D2F4 RID: 54004 RVA: 0x001F1A17 File Offset: 0x001EFC17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D2F5 RID: 54005 RVA: 0x001F1A20 File Offset: 0x001EFC20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D2F6 RID: 54006 RVA: 0x001F1A38 File Offset: 0x001EFC38
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

		// Token: 0x0600D2F7 RID: 54007 RVA: 0x001F1A5E File Offset: 0x001EFC5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LowMemoryChangeSceneFinishRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D2F8 RID: 54008 RVA: 0x001F1A7B File Offset: 0x001EFC7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D2F9 RID: 54009 RVA: 0x001F1A84 File Offset: 0x001EFC84
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

		// Token: 0x04005914 RID: 22804
		private UnknownFieldSet _unknownFields;
	}
}
