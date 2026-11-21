using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001592 RID: 5522
	[NetMessage(EMessageId.WorldLevelRegainRequest)]
	public sealed class WorldLevelRegainRequest : IMessage<WorldLevelRegainRequest>, IMessage, IEquatable<WorldLevelRegainRequest>, IDeepCloneable<WorldLevelRegainRequest>, IBufferMessage
	{
		// Token: 0x0601D3A2 RID: 119714 RVA: 0x0043B07C File Offset: 0x0043927C
		[NullableContext(1)]
		public static WorldLevelRegainRequest Create()
		{
			return new WorldLevelRegainRequest();
		}

		// Token: 0x170062DD RID: 25309
		// (get) Token: 0x0601D3A3 RID: 119715 RVA: 0x0043B083 File Offset: 0x00439283
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170062DE RID: 25310
		// (get) Token: 0x0601D3A4 RID: 119716 RVA: 0x0043B086 File Offset: 0x00439286
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WorldLevelRegainRequest.Descriptor;
			}
		}

		// Token: 0x0601D3A5 RID: 119717 RVA: 0x0043B08D File Offset: 0x0043928D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorldLevelRegainRequest()
		{
		}

		// Token: 0x0601D3A6 RID: 119718 RVA: 0x0043B095 File Offset: 0x00439295
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorldLevelRegainRequest(WorldLevelRegainRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D3A7 RID: 119719 RVA: 0x0043B0AE File Offset: 0x004392AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorldLevelRegainRequest Clone()
		{
			return new WorldLevelRegainRequest(this);
		}

		// Token: 0x0601D3A8 RID: 119720 RVA: 0x0043B0B6 File Offset: 0x004392B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WorldLevelRegainRequest);
		}

		// Token: 0x0601D3A9 RID: 119721 RVA: 0x0043B0C4 File Offset: 0x004392C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WorldLevelRegainRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601D3AA RID: 119722 RVA: 0x0043B0E4 File Offset: 0x004392E4
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

		// Token: 0x0601D3AB RID: 119723 RVA: 0x0043B10A File Offset: 0x0043930A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D3AC RID: 119724 RVA: 0x0043B117 File Offset: 0x00439317
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D3AD RID: 119725 RVA: 0x0043B120 File Offset: 0x00439320
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D3AE RID: 119726 RVA: 0x0043B138 File Offset: 0x00439338
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

		// Token: 0x0601D3AF RID: 119727 RVA: 0x0043B15E File Offset: 0x0043935E
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

		// Token: 0x0601D3B0 RID: 119728 RVA: 0x0043B17B File Offset: 0x0043937B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D3B1 RID: 119729 RVA: 0x0043B184 File Offset: 0x00439384
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

		// Token: 0x0400A7A0 RID: 42912
		private UnknownFieldSet _unknownFields;
	}
}
