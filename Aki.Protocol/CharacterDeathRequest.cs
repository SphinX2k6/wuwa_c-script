using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000273 RID: 627
	[NetMessage(EMessageId.CharacterDeathRequest)]
	public sealed class CharacterDeathRequest : IMessage<CharacterDeathRequest>, IMessage, IEquatable<CharacterDeathRequest>, IDeepCloneable<CharacterDeathRequest>, IBufferMessage
	{
		// Token: 0x060041FD RID: 16893 RVA: 0x000A1F4C File Offset: 0x000A014C
		[NullableContext(1)]
		public static CharacterDeathRequest Create()
		{
			return new CharacterDeathRequest();
		}

		// Token: 0x17000B2D RID: 2861
		// (get) Token: 0x060041FE RID: 16894 RVA: 0x000A1F53 File Offset: 0x000A0153
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000B2E RID: 2862
		// (get) Token: 0x060041FF RID: 16895 RVA: 0x000A1F56 File Offset: 0x000A0156
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CharacterDeathRequest.Descriptor;
			}
		}

		// Token: 0x06004200 RID: 16896 RVA: 0x000A1F5D File Offset: 0x000A015D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CharacterDeathRequest()
		{
		}

		// Token: 0x06004201 RID: 16897 RVA: 0x000A1F65 File Offset: 0x000A0165
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CharacterDeathRequest(CharacterDeathRequest other) : this()
		{
			this.roleId_ = other.roleId_;
			this.result_ = other.result_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004202 RID: 16898 RVA: 0x000A1F96 File Offset: 0x000A0196
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CharacterDeathRequest Clone()
		{
			return new CharacterDeathRequest(this);
		}

		// Token: 0x17000B2F RID: 2863
		// (get) Token: 0x06004203 RID: 16899 RVA: 0x000A1F9E File Offset: 0x000A019E
		// (set) Token: 0x06004204 RID: 16900 RVA: 0x000A1FA6 File Offset: 0x000A01A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleId
		{
			get
			{
				return this.roleId_;
			}
			set
			{
				this.roleId_ = value;
			}
		}

		// Token: 0x17000B30 RID: 2864
		// (get) Token: 0x06004205 RID: 16901 RVA: 0x000A1FAF File Offset: 0x000A01AF
		// (set) Token: 0x06004206 RID: 16902 RVA: 0x000A1FB7 File Offset: 0x000A01B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Result
		{
			get
			{
				return this.result_;
			}
			set
			{
				this.result_ = value;
			}
		}

		// Token: 0x06004207 RID: 16903 RVA: 0x000A1FC0 File Offset: 0x000A01C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CharacterDeathRequest);
		}

		// Token: 0x06004208 RID: 16904 RVA: 0x000A1FCE File Offset: 0x000A01CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CharacterDeathRequest other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.Result == other.Result && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004209 RID: 16905 RVA: 0x000A200C File Offset: 0x000A020C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this.Result != 0)
			{
				num ^= this.Result.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600420A RID: 16906 RVA: 0x000A2064 File Offset: 0x000A0264
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600420B RID: 16907 RVA: 0x000A2071 File Offset: 0x000A0271
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600420C RID: 16908 RVA: 0x000A207C File Offset: 0x000A027C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Result != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Result);
			}
			if (this.RoleId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600420D RID: 16909 RVA: 0x000A20D8 File Offset: 0x000A02D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this.Result != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Result);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600420E RID: 16910 RVA: 0x000A2130 File Offset: 0x000A0330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CharacterDeathRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			if (other.Result != 0)
			{
				this.Result = other.Result;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600420F RID: 16911 RVA: 0x000A2180 File Offset: 0x000A0380
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004210 RID: 16912 RVA: 0x000A218C File Offset: 0x000A038C
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
				if (num != 16U)
				{
					if (num != 32U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.RoleId = input.ReadInt32();
					}
				}
				else
				{
					this.Result = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002DE2 RID: 11746
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002DE3 RID: 11747
		public const int RoleIdFieldNumber = 4;

		// Token: 0x04002DE4 RID: 11748
		private int roleId_;

		// Token: 0x04002DE5 RID: 11749
		public const int ResultFieldNumber = 2;

		// Token: 0x04002DE6 RID: 11750
		private int result_;
	}
}
