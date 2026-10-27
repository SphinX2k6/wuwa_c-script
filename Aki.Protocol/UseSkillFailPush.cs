using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014B5 RID: 5301
	[NetMessage(EMessageId.UseSkillFailPush)]
	public sealed class UseSkillFailPush : IMessage<UseSkillFailPush>, IMessage, IEquatable<UseSkillFailPush>, IDeepCloneable<UseSkillFailPush>, IBufferMessage
	{
		// Token: 0x0601C085 RID: 114821 RVA: 0x0040D3CC File Offset: 0x0040B5CC
		[NullableContext(1)]
		public static UseSkillFailPush Create()
		{
			return new UseSkillFailPush();
		}

		// Token: 0x17005E79 RID: 24185
		// (get) Token: 0x0601C086 RID: 114822 RVA: 0x0040D3D3 File Offset: 0x0040B5D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005E7A RID: 24186
		// (get) Token: 0x0601C087 RID: 114823 RVA: 0x0040D3D6 File Offset: 0x0040B5D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UseSkillFailPush.Descriptor;
			}
		}

		// Token: 0x0601C088 RID: 114824 RVA: 0x0040D3DD File Offset: 0x0040B5DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UseSkillFailPush()
		{
		}

		// Token: 0x0601C089 RID: 114825 RVA: 0x0040D3E5 File Offset: 0x0040B5E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UseSkillFailPush(UseSkillFailPush other) : this()
		{
			this.skillId_ = other.skillId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C08A RID: 114826 RVA: 0x0040D40A File Offset: 0x0040B60A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UseSkillFailPush Clone()
		{
			return new UseSkillFailPush(this);
		}

		// Token: 0x17005E7B RID: 24187
		// (get) Token: 0x0601C08B RID: 114827 RVA: 0x0040D412 File Offset: 0x0040B612
		// (set) Token: 0x0601C08C RID: 114828 RVA: 0x0040D41A File Offset: 0x0040B61A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long SkillId
		{
			get
			{
				return this.skillId_;
			}
			set
			{
				this.skillId_ = value;
			}
		}

		// Token: 0x0601C08D RID: 114829 RVA: 0x0040D423 File Offset: 0x0040B623
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UseSkillFailPush);
		}

		// Token: 0x0601C08E RID: 114830 RVA: 0x0040D431 File Offset: 0x0040B631
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UseSkillFailPush other)
		{
			return other != null && (other == this || (this.SkillId == other.SkillId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C08F RID: 114831 RVA: 0x0040D460 File Offset: 0x0040B660
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SkillId != 0L)
			{
				num ^= this.SkillId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C090 RID: 114832 RVA: 0x0040D49F File Offset: 0x0040B69F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C091 RID: 114833 RVA: 0x0040D4AC File Offset: 0x0040B6AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C092 RID: 114834 RVA: 0x0040D4B5 File Offset: 0x0040B6B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SkillId != 0L)
			{
				output.WriteRawTag(112);
				output.WriteInt64(this.SkillId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C093 RID: 114835 RVA: 0x0040D4E8 File Offset: 0x0040B6E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SkillId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.SkillId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C094 RID: 114836 RVA: 0x0040D526 File Offset: 0x0040B726
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UseSkillFailPush other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SkillId != 0L)
			{
				this.SkillId = other.SkillId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C095 RID: 114837 RVA: 0x0040D557 File Offset: 0x0040B757
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C096 RID: 114838 RVA: 0x0040D560 File Offset: 0x0040B760
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.SkillId = input.ReadInt64();
				}
			}
		}

		// Token: 0x0400A0FD RID: 41213
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A0FE RID: 41214
		public const int SkillIdFieldNumber = 14;

		// Token: 0x0400A0FF RID: 41215
		private long skillId_;
	}
}
