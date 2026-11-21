using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200109A RID: 4250
	public sealed class RoleShowEntry : IMessage<RoleShowEntry>, IMessage, IEquatable<RoleShowEntry>, IDeepCloneable<RoleShowEntry>, IBufferMessage
	{
		// Token: 0x06016B96 RID: 93078 RVA: 0x0034DFCC File Offset: 0x0034C1CC
		[NullableContext(1)]
		public static RoleShowEntry Create()
		{
			return new RoleShowEntry();
		}

		// Token: 0x17004C2A RID: 19498
		// (get) Token: 0x06016B97 RID: 93079 RVA: 0x0034DFD3 File Offset: 0x0034C1D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RoleShowEntry> Parser
		{
			get
			{
				return RoleShowEntry._parser;
			}
		}

		// Token: 0x17004C2B RID: 19499
		// (get) Token: 0x06016B98 RID: 93080 RVA: 0x0034DFDA File Offset: 0x0034C1DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004C2C RID: 19500
		// (get) Token: 0x06016B99 RID: 93081 RVA: 0x0034DFDD File Offset: 0x0034C1DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleShowEntry.Descriptor;
			}
		}

		// Token: 0x06016B9A RID: 93082 RVA: 0x0034DFE4 File Offset: 0x0034C1E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleShowEntry()
		{
		}

		// Token: 0x06016B9B RID: 93083 RVA: 0x0034DFEC File Offset: 0x0034C1EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleShowEntry(RoleShowEntry other) : this()
		{
			this.roleId_ = other.roleId_;
			this.level_ = other.level_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016B9C RID: 93084 RVA: 0x0034E01D File Offset: 0x0034C21D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleShowEntry Clone()
		{
			return new RoleShowEntry(this);
		}

		// Token: 0x17004C2D RID: 19501
		// (get) Token: 0x06016B9D RID: 93085 RVA: 0x0034E025 File Offset: 0x0034C225
		// (set) Token: 0x06016B9E RID: 93086 RVA: 0x0034E02D File Offset: 0x0034C22D
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

		// Token: 0x17004C2E RID: 19502
		// (get) Token: 0x06016B9F RID: 93087 RVA: 0x0034E036 File Offset: 0x0034C236
		// (set) Token: 0x06016BA0 RID: 93088 RVA: 0x0034E03E File Offset: 0x0034C23E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x06016BA1 RID: 93089 RVA: 0x0034E047 File Offset: 0x0034C247
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleShowEntry);
		}

		// Token: 0x06016BA2 RID: 93090 RVA: 0x0034E055 File Offset: 0x0034C255
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleShowEntry other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.Level == other.Level && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016BA3 RID: 93091 RVA: 0x0034E094 File Offset: 0x0034C294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this.Level != 0)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016BA4 RID: 93092 RVA: 0x0034E0EC File Offset: 0x0034C2EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016BA5 RID: 93093 RVA: 0x0034E0F9 File Offset: 0x0034C2F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016BA6 RID: 93094 RVA: 0x0034E104 File Offset: 0x0034C304
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RoleId);
			}
			if (this.Level != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Level);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016BA7 RID: 93095 RVA: 0x0034E15C File Offset: 0x0034C35C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this.Level != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Level);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016BA8 RID: 93096 RVA: 0x0034E1B4 File Offset: 0x0034C3B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleShowEntry other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			if (other.Level != 0)
			{
				this.Level = other.Level;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016BA9 RID: 93097 RVA: 0x0034E204 File Offset: 0x0034C404
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016BAA RID: 93098 RVA: 0x0034E210 File Offset: 0x0034C410
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
				if (num != 8U)
				{
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Level = input.ReadInt32();
					}
				}
				else
				{
					this.RoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400882C RID: 34860
		private static readonly MessageParser<RoleShowEntry> _parser = new MessageParser<RoleShowEntry>(() => new RoleShowEntry());

		// Token: 0x0400882D RID: 34861
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400882E RID: 34862
		public const int RoleIdFieldNumber = 1;

		// Token: 0x0400882F RID: 34863
		private int roleId_;

		// Token: 0x04008830 RID: 34864
		public const int LevelFieldNumber = 2;

		// Token: 0x04008831 RID: 34865
		private int level_;
	}
}
