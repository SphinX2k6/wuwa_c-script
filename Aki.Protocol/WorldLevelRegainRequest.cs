using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200151C RID: 5404
	[NetMessage(EMessageId.WorldLevelRegainRequest)]
	public sealed class WorldLevelRegainRequest : IMessage<WorldLevelRegainRequest>, IMessage, IEquatable<WorldLevelRegainRequest>, IDeepCloneable<WorldLevelRegainRequest>, IBufferMessage
	{
		// Token: 0x0601C8DB RID: 116955 RVA: 0x0041F5C1 File Offset: 0x0041D7C1
		[NullableContext(1)]
		public static WorldLevelRegainRequest Create()
		{
			return new WorldLevelRegainRequest();
		}

		// Token: 0x1700603C RID: 24636
		// (get) Token: 0x0601C8DC RID: 116956 RVA: 0x0041F5C8 File Offset: 0x0041D7C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700603D RID: 24637
		// (get) Token: 0x0601C8DD RID: 116957 RVA: 0x0041F5CB File Offset: 0x0041D7CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WorldLevelRegainRequest.Descriptor;
			}
		}

		// Token: 0x0601C8DE RID: 116958 RVA: 0x0041F5D2 File Offset: 0x0041D7D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorldLevelRegainRequest()
		{
		}

		// Token: 0x0601C8DF RID: 116959 RVA: 0x0041F5DA File Offset: 0x0041D7DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorldLevelRegainRequest(WorldLevelRegainRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C8E0 RID: 116960 RVA: 0x0041F5F3 File Offset: 0x0041D7F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorldLevelRegainRequest Clone()
		{
			return new WorldLevelRegainRequest(this);
		}

		// Token: 0x0601C8E1 RID: 116961 RVA: 0x0041F5FB File Offset: 0x0041D7FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WorldLevelRegainRequest);
		}

		// Token: 0x0601C8E2 RID: 116962 RVA: 0x0041F609 File Offset: 0x0041D809
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WorldLevelRegainRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601C8E3 RID: 116963 RVA: 0x0041F628 File Offset: 0x0041D828
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

		// Token: 0x0601C8E4 RID: 116964 RVA: 0x0041F64E File Offset: 0x0041D84E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C8E5 RID: 116965 RVA: 0x0041F65B File Offset: 0x0041D85B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C8E6 RID: 116966 RVA: 0x0041F664 File Offset: 0x0041D864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C8E7 RID: 116967 RVA: 0x0041F67C File Offset: 0x0041D87C
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

		// Token: 0x0601C8E8 RID: 116968 RVA: 0x0041F6A2 File Offset: 0x0041D8A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WorldLevelRegainRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C8E9 RID: 116969 RVA: 0x0041F6BF File Offset: 0x0041D8BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C8EA RID: 116970 RVA: 0x0041F6C8 File Offset: 0x0041D8C8
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

		// Token: 0x0400A347 RID: 41799
		private UnknownFieldSet _unknownFields;
	}
}
