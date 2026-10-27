using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014BC RID: 5308
	[NetMessage(EMessageId.UseSoundBoxSkillRequest)]
	public sealed class UseSoundBoxSkillRequest : IMessage<UseSoundBoxSkillRequest>, IMessage, IEquatable<UseSoundBoxSkillRequest>, IDeepCloneable<UseSoundBoxSkillRequest>, IBufferMessage
	{
		// Token: 0x0601C127 RID: 114983 RVA: 0x0040EFB2 File Offset: 0x0040D1B2
		[NullableContext(1)]
		public static UseSoundBoxSkillRequest Create()
		{
			return new UseSoundBoxSkillRequest();
		}

		// Token: 0x17005EA0 RID: 24224
		// (get) Token: 0x0601C128 RID: 114984 RVA: 0x0040EFB9 File Offset: 0x0040D1B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005EA1 RID: 24225
		// (get) Token: 0x0601C129 RID: 114985 RVA: 0x0040EFBC File Offset: 0x0040D1BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UseSoundBoxSkillRequest.Descriptor;
			}
		}

		// Token: 0x0601C12A RID: 114986 RVA: 0x0040EFC3 File Offset: 0x0040D1C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UseSoundBoxSkillRequest()
		{
		}

		// Token: 0x0601C12B RID: 114987 RVA: 0x0040EFCB File Offset: 0x0040D1CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UseSoundBoxSkillRequest(UseSoundBoxSkillRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C12C RID: 114988 RVA: 0x0040EFE4 File Offset: 0x0040D1E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UseSoundBoxSkillRequest Clone()
		{
			return new UseSoundBoxSkillRequest(this);
		}

		// Token: 0x0601C12D RID: 114989 RVA: 0x0040EFEC File Offset: 0x0040D1EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UseSoundBoxSkillRequest);
		}

		// Token: 0x0601C12E RID: 114990 RVA: 0x0040EFFA File Offset: 0x0040D1FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UseSoundBoxSkillRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601C12F RID: 114991 RVA: 0x0040F018 File Offset: 0x0040D218
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

		// Token: 0x0601C130 RID: 114992 RVA: 0x0040F03E File Offset: 0x0040D23E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C131 RID: 114993 RVA: 0x0040F04B File Offset: 0x0040D24B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C132 RID: 114994 RVA: 0x0040F054 File Offset: 0x0040D254
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C133 RID: 114995 RVA: 0x0040F06C File Offset: 0x0040D26C
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

		// Token: 0x0601C134 RID: 114996 RVA: 0x0040F092 File Offset: 0x0040D292
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

		// Token: 0x0601C135 RID: 114997 RVA: 0x0040F0AF File Offset: 0x0040D2AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C136 RID: 114998 RVA: 0x0040F0B8 File Offset: 0x0040D2B8
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

		// Token: 0x0400A137 RID: 41271
		private UnknownFieldSet _unknownFields;
	}
}
