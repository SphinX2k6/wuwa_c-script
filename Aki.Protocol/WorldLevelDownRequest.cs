using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001590 RID: 5520
	[NetMessage(EMessageId.WorldLevelDownRequest)]
	public sealed class WorldLevelDownRequest : IMessage<WorldLevelDownRequest>, IMessage, IEquatable<WorldLevelDownRequest>, IDeepCloneable<WorldLevelDownRequest>, IBufferMessage
	{
		// Token: 0x0601D37A RID: 119674 RVA: 0x0043AB44 File Offset: 0x00438D44
		[NullableContext(1)]
		public static WorldLevelDownRequest Create()
		{
			return new WorldLevelDownRequest();
		}

		// Token: 0x170062D5 RID: 25301
		// (get) Token: 0x0601D37B RID: 119675 RVA: 0x0043AB4B File Offset: 0x00438D4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170062D6 RID: 25302
		// (get) Token: 0x0601D37C RID: 119676 RVA: 0x0043AB4E File Offset: 0x00438D4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WorldLevelDownRequest.Descriptor;
			}
		}

		// Token: 0x0601D37D RID: 119677 RVA: 0x0043AB55 File Offset: 0x00438D55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorldLevelDownRequest()
		{
		}

		// Token: 0x0601D37E RID: 119678 RVA: 0x0043AB5D File Offset: 0x00438D5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorldLevelDownRequest(WorldLevelDownRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D37F RID: 119679 RVA: 0x0043AB76 File Offset: 0x00438D76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorldLevelDownRequest Clone()
		{
			return new WorldLevelDownRequest(this);
		}

		// Token: 0x0601D380 RID: 119680 RVA: 0x0043AB7E File Offset: 0x00438D7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WorldLevelDownRequest);
		}

		// Token: 0x0601D381 RID: 119681 RVA: 0x0043AB8C File Offset: 0x00438D8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WorldLevelDownRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601D382 RID: 119682 RVA: 0x0043ABAC File Offset: 0x00438DAC
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

		// Token: 0x0601D383 RID: 119683 RVA: 0x0043ABD2 File Offset: 0x00438DD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D384 RID: 119684 RVA: 0x0043ABDF File Offset: 0x00438DDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D385 RID: 119685 RVA: 0x0043ABE8 File Offset: 0x00438DE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D386 RID: 119686 RVA: 0x0043AC00 File Offset: 0x00438E00
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

		// Token: 0x0601D387 RID: 119687 RVA: 0x0043AC26 File Offset: 0x00438E26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WorldLevelDownRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601D388 RID: 119688 RVA: 0x0043AC43 File Offset: 0x00438E43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D389 RID: 119689 RVA: 0x0043AC4C File Offset: 0x00438E4C
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

		// Token: 0x0400A796 RID: 42902
		private UnknownFieldSet _unknownFields;
	}
}
