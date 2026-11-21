using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001532 RID: 5426
	[NetMessage(EMessageId.UseSoundBoxSkillRequest)]
	public sealed class UseSoundBoxSkillRequest : IMessage<UseSoundBoxSkillRequest>, IMessage, IEquatable<UseSoundBoxSkillRequest>, IDeepCloneable<UseSoundBoxSkillRequest>, IBufferMessage
	{
		// Token: 0x0601CBEE RID: 117742 RVA: 0x0042AA6A File Offset: 0x00428C6A
		[NullableContext(1)]
		public static UseSoundBoxSkillRequest Create()
		{
			return new UseSoundBoxSkillRequest();
		}

		// Token: 0x17006141 RID: 24897
		// (get) Token: 0x0601CBEF RID: 117743 RVA: 0x0042AA71 File Offset: 0x00428C71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006142 RID: 24898
		// (get) Token: 0x0601CBF0 RID: 117744 RVA: 0x0042AA74 File Offset: 0x00428C74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UseSoundBoxSkillRequest.Descriptor;
			}
		}

		// Token: 0x0601CBF1 RID: 117745 RVA: 0x0042AA7B File Offset: 0x00428C7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UseSoundBoxSkillRequest()
		{
		}

		// Token: 0x0601CBF2 RID: 117746 RVA: 0x0042AA83 File Offset: 0x00428C83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UseSoundBoxSkillRequest(UseSoundBoxSkillRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CBF3 RID: 117747 RVA: 0x0042AA9C File Offset: 0x00428C9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UseSoundBoxSkillRequest Clone()
		{
			return new UseSoundBoxSkillRequest(this);
		}

		// Token: 0x0601CBF4 RID: 117748 RVA: 0x0042AAA4 File Offset: 0x00428CA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UseSoundBoxSkillRequest);
		}

		// Token: 0x0601CBF5 RID: 117749 RVA: 0x0042AAB2 File Offset: 0x00428CB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UseSoundBoxSkillRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601CBF6 RID: 117750 RVA: 0x0042AAD0 File Offset: 0x00428CD0
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

		// Token: 0x0601CBF7 RID: 117751 RVA: 0x0042AAF6 File Offset: 0x00428CF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CBF8 RID: 117752 RVA: 0x0042AB03 File Offset: 0x00428D03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CBF9 RID: 117753 RVA: 0x0042AB0C File Offset: 0x00428D0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CBFA RID: 117754 RVA: 0x0042AB24 File Offset: 0x00428D24
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

		// Token: 0x0601CBFB RID: 117755 RVA: 0x0042AB4A File Offset: 0x00428D4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UseSoundBoxSkillRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601CBFC RID: 117756 RVA: 0x0042AB67 File Offset: 0x00428D67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CBFD RID: 117757 RVA: 0x0042AB70 File Offset: 0x00428D70
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

		// Token: 0x0400A590 RID: 42384
		private UnknownFieldSet _unknownFields;
	}
}
