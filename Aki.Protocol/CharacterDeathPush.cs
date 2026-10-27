using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000272 RID: 626
	[NetMessage(EMessageId.CharacterDeathPush)]
	public sealed class CharacterDeathPush : IMessage<CharacterDeathPush>, IMessage, IEquatable<CharacterDeathPush>, IDeepCloneable<CharacterDeathPush>, IBufferMessage
	{
		// Token: 0x060041E9 RID: 16873 RVA: 0x000A1CB3 File Offset: 0x0009FEB3
		[NullableContext(1)]
		public static CharacterDeathPush Create()
		{
			return new CharacterDeathPush();
		}

		// Token: 0x17000B29 RID: 2857
		// (get) Token: 0x060041EA RID: 16874 RVA: 0x000A1CBA File Offset: 0x0009FEBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000B2A RID: 2858
		// (get) Token: 0x060041EB RID: 16875 RVA: 0x000A1CBD File Offset: 0x0009FEBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CharacterDeathPush.Descriptor;
			}
		}

		// Token: 0x060041EC RID: 16876 RVA: 0x000A1CC4 File Offset: 0x0009FEC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CharacterDeathPush()
		{
		}

		// Token: 0x060041ED RID: 16877 RVA: 0x000A1CCC File Offset: 0x0009FECC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CharacterDeathPush(CharacterDeathPush other) : this()
		{
			this.roleId_ = other.roleId_;
			this.result_ = other.result_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060041EE RID: 16878 RVA: 0x000A1CFD File Offset: 0x0009FEFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CharacterDeathPush Clone()
		{
			return new CharacterDeathPush(this);
		}

		// Token: 0x17000B2B RID: 2859
		// (get) Token: 0x060041EF RID: 16879 RVA: 0x000A1D05 File Offset: 0x0009FF05
		// (set) Token: 0x060041F0 RID: 16880 RVA: 0x000A1D0D File Offset: 0x0009FF0D
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

		// Token: 0x17000B2C RID: 2860
		// (get) Token: 0x060041F1 RID: 16881 RVA: 0x000A1D16 File Offset: 0x0009FF16
		// (set) Token: 0x060041F2 RID: 16882 RVA: 0x000A1D1E File Offset: 0x0009FF1E
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

		// Token: 0x060041F3 RID: 16883 RVA: 0x000A1D27 File Offset: 0x0009FF27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CharacterDeathPush);
		}

		// Token: 0x060041F4 RID: 16884 RVA: 0x000A1D35 File Offset: 0x0009FF35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CharacterDeathPush other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.Result == other.Result && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060041F5 RID: 16885 RVA: 0x000A1D74 File Offset: 0x0009FF74
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

		// Token: 0x060041F6 RID: 16886 RVA: 0x000A1DCC File Offset: 0x0009FFCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060041F7 RID: 16887 RVA: 0x000A1DD9 File Offset: 0x0009FFD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060041F8 RID: 16888 RVA: 0x000A1DE4 File Offset: 0x0009FFE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.RoleId);
			}
			if (this.Result != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.Result);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060041F9 RID: 16889 RVA: 0x000A1E40 File Offset: 0x000A0040
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

		// Token: 0x060041FA RID: 16890 RVA: 0x000A1E98 File Offset: 0x000A0098
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

		// Token: 0x060041FB RID: 16891 RVA: 0x000A1EE8 File Offset: 0x000A00E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060041FC RID: 16892 RVA: 0x000A1EF4 File Offset: 0x000A00F4
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
				if (num != 24U)
				{
					if (num != 40U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Result = input.ReadInt32();
					}
				}
				else
				{
					this.RoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002DDD RID: 11741
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002DDE RID: 11742
		public const int RoleIdFieldNumber = 3;

		// Token: 0x04002DDF RID: 11743
		private int roleId_;

		// Token: 0x04002DE0 RID: 11744
		public const int ResultFieldNumber = 5;

		// Token: 0x04002DE1 RID: 11745
		private int result_;
	}
}
