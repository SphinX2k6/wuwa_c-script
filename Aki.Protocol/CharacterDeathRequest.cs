using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000278 RID: 632
	[NetMessage(EMessageId.CharacterDeathRequest)]
	public sealed class CharacterDeathRequest : IMessage<CharacterDeathRequest>, IMessage, IEquatable<CharacterDeathRequest>, IDeepCloneable<CharacterDeathRequest>, IBufferMessage
	{
		// Token: 0x060042A4 RID: 17060 RVA: 0x000A3C18 File Offset: 0x000A1E18
		[NullableContext(1)]
		public static CharacterDeathRequest Create()
		{
			return new CharacterDeathRequest();
		}

		// Token: 0x17000B4D RID: 2893
		// (get) Token: 0x060042A5 RID: 17061 RVA: 0x000A3C1F File Offset: 0x000A1E1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000B4E RID: 2894
		// (get) Token: 0x060042A6 RID: 17062 RVA: 0x000A3C22 File Offset: 0x000A1E22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CharacterDeathRequest.Descriptor;
			}
		}

		// Token: 0x060042A7 RID: 17063 RVA: 0x000A3C29 File Offset: 0x000A1E29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CharacterDeathRequest()
		{
		}

		// Token: 0x060042A8 RID: 17064 RVA: 0x000A3C31 File Offset: 0x000A1E31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CharacterDeathRequest(CharacterDeathRequest other) : this()
		{
			this.roleId_ = other.roleId_;
			this.result_ = other.result_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060042A9 RID: 17065 RVA: 0x000A3C62 File Offset: 0x000A1E62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CharacterDeathRequest Clone()
		{
			return new CharacterDeathRequest(this);
		}

		// Token: 0x17000B4F RID: 2895
		// (get) Token: 0x060042AA RID: 17066 RVA: 0x000A3C6A File Offset: 0x000A1E6A
		// (set) Token: 0x060042AB RID: 17067 RVA: 0x000A3C72 File Offset: 0x000A1E72
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

		// Token: 0x17000B50 RID: 2896
		// (get) Token: 0x060042AC RID: 17068 RVA: 0x000A3C7B File Offset: 0x000A1E7B
		// (set) Token: 0x060042AD RID: 17069 RVA: 0x000A3C83 File Offset: 0x000A1E83
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

		// Token: 0x060042AE RID: 17070 RVA: 0x000A3C8C File Offset: 0x000A1E8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CharacterDeathRequest);
		}

		// Token: 0x060042AF RID: 17071 RVA: 0x000A3C9A File Offset: 0x000A1E9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CharacterDeathRequest other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.Result == other.Result && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060042B0 RID: 17072 RVA: 0x000A3CD8 File Offset: 0x000A1ED8
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

		// Token: 0x060042B1 RID: 17073 RVA: 0x000A3D30 File Offset: 0x000A1F30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060042B2 RID: 17074 RVA: 0x000A3D3D File Offset: 0x000A1F3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060042B3 RID: 17075 RVA: 0x000A3D48 File Offset: 0x000A1F48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Result != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.Result);
			}
			if (this.RoleId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060042B4 RID: 17076 RVA: 0x000A3DA4 File Offset: 0x000A1FA4
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

		// Token: 0x060042B5 RID: 17077 RVA: 0x000A3DFC File Offset: 0x000A1FFC
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

		// Token: 0x060042B6 RID: 17078 RVA: 0x000A3E4C File Offset: 0x000A204C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060042B7 RID: 17079 RVA: 0x000A3E58 File Offset: 0x000A2058
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
				if (num != 72U)
				{
					if (num != 96U)
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

		// Token: 0x04002E66 RID: 11878
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002E67 RID: 11879
		public const int RoleIdFieldNumber = 12;

		// Token: 0x04002E68 RID: 11880
		private int roleId_;

		// Token: 0x04002E69 RID: 11881
		public const int ResultFieldNumber = 9;

		// Token: 0x04002E6A RID: 11882
		private int result_;
	}
}
