using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000277 RID: 631
	[NetMessage(EMessageId.CharacterDeathPush)]
	public sealed class CharacterDeathPush : IMessage<CharacterDeathPush>, IMessage, IEquatable<CharacterDeathPush>, IDeepCloneable<CharacterDeathPush>, IBufferMessage
	{
		// Token: 0x06004290 RID: 17040 RVA: 0x000A397F File Offset: 0x000A1B7F
		[NullableContext(1)]
		public static CharacterDeathPush Create()
		{
			return new CharacterDeathPush();
		}

		// Token: 0x17000B49 RID: 2889
		// (get) Token: 0x06004291 RID: 17041 RVA: 0x000A3986 File Offset: 0x000A1B86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000B4A RID: 2890
		// (get) Token: 0x06004292 RID: 17042 RVA: 0x000A3989 File Offset: 0x000A1B89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CharacterDeathPush.Descriptor;
			}
		}

		// Token: 0x06004293 RID: 17043 RVA: 0x000A3990 File Offset: 0x000A1B90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CharacterDeathPush()
		{
		}

		// Token: 0x06004294 RID: 17044 RVA: 0x000A3998 File Offset: 0x000A1B98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CharacterDeathPush(CharacterDeathPush other) : this()
		{
			this.roleId_ = other.roleId_;
			this.result_ = other.result_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004295 RID: 17045 RVA: 0x000A39C9 File Offset: 0x000A1BC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CharacterDeathPush Clone()
		{
			return new CharacterDeathPush(this);
		}

		// Token: 0x17000B4B RID: 2891
		// (get) Token: 0x06004296 RID: 17046 RVA: 0x000A39D1 File Offset: 0x000A1BD1
		// (set) Token: 0x06004297 RID: 17047 RVA: 0x000A39D9 File Offset: 0x000A1BD9
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

		// Token: 0x17000B4C RID: 2892
		// (get) Token: 0x06004298 RID: 17048 RVA: 0x000A39E2 File Offset: 0x000A1BE2
		// (set) Token: 0x06004299 RID: 17049 RVA: 0x000A39EA File Offset: 0x000A1BEA
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

		// Token: 0x0600429A RID: 17050 RVA: 0x000A39F3 File Offset: 0x000A1BF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CharacterDeathPush);
		}

		// Token: 0x0600429B RID: 17051 RVA: 0x000A3A01 File Offset: 0x000A1C01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CharacterDeathPush other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.Result == other.Result && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600429C RID: 17052 RVA: 0x000A3A40 File Offset: 0x000A1C40
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

		// Token: 0x0600429D RID: 17053 RVA: 0x000A3A98 File Offset: 0x000A1C98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600429E RID: 17054 RVA: 0x000A3AA5 File Offset: 0x000A1CA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600429F RID: 17055 RVA: 0x000A3AB0 File Offset: 0x000A1CB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Result != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.Result);
			}
			if (this.RoleId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060042A0 RID: 17056 RVA: 0x000A3B0C File Offset: 0x000A1D0C
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

		// Token: 0x060042A1 RID: 17057 RVA: 0x000A3B64 File Offset: 0x000A1D64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CharacterDeathPush other)
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

		// Token: 0x060042A2 RID: 17058 RVA: 0x000A3BB4 File Offset: 0x000A1DB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060042A3 RID: 17059 RVA: 0x000A3BC0 File Offset: 0x000A1DC0
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
				if (num != 64U)
				{
					if (num != 88U)
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

		// Token: 0x04002E61 RID: 11873
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002E62 RID: 11874
		public const int RoleIdFieldNumber = 11;

		// Token: 0x04002E63 RID: 11875
		private int roleId_;

		// Token: 0x04002E64 RID: 11876
		public const int ResultFieldNumber = 8;

		// Token: 0x04002E65 RID: 11877
		private int result_;
	}
}
