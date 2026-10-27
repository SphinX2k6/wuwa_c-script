using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013C5 RID: 5061
	[NetMessage(EMessageId.TowerRequest)]
	public sealed class TowerRequest : IMessage<TowerRequest>, IMessage, IEquatable<TowerRequest>, IDeepCloneable<TowerRequest>, IBufferMessage
	{
		// Token: 0x0601AD8B RID: 109963 RVA: 0x003E4724 File Offset: 0x003E2924
		[NullableContext(1)]
		public static TowerRequest Create()
		{
			return new TowerRequest();
		}

		// Token: 0x17005A8C RID: 23180
		// (get) Token: 0x0601AD8C RID: 109964 RVA: 0x003E472B File Offset: 0x003E292B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005A8D RID: 23181
		// (get) Token: 0x0601AD8D RID: 109965 RVA: 0x003E472E File Offset: 0x003E292E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerRequest.Descriptor;
			}
		}

		// Token: 0x0601AD8E RID: 109966 RVA: 0x003E4735 File Offset: 0x003E2935
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerRequest()
		{
		}

		// Token: 0x0601AD8F RID: 109967 RVA: 0x003E473D File Offset: 0x003E293D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerRequest(TowerRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AD90 RID: 109968 RVA: 0x003E4756 File Offset: 0x003E2956
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerRequest Clone()
		{
			return new TowerRequest(this);
		}

		// Token: 0x0601AD91 RID: 109969 RVA: 0x003E475E File Offset: 0x003E295E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerRequest);
		}

		// Token: 0x0601AD92 RID: 109970 RVA: 0x003E476C File Offset: 0x003E296C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601AD93 RID: 109971 RVA: 0x003E478C File Offset: 0x003E298C
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

		// Token: 0x0601AD94 RID: 109972 RVA: 0x003E47B2 File Offset: 0x003E29B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AD95 RID: 109973 RVA: 0x003E47BF File Offset: 0x003E29BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AD96 RID: 109974 RVA: 0x003E47C8 File Offset: 0x003E29C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601AD97 RID: 109975 RVA: 0x003E47E0 File Offset: 0x003E29E0
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

		// Token: 0x0601AD98 RID: 109976 RVA: 0x003E4806 File Offset: 0x003E2A06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TowerRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601AD99 RID: 109977 RVA: 0x003E4823 File Offset: 0x003E2A23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AD9A RID: 109978 RVA: 0x003E482C File Offset: 0x003E2A2C
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

		// Token: 0x04009BCC RID: 39884
		private UnknownFieldSet _unknownFields;
	}
}
