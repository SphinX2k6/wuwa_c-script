using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200071E RID: 1822
	public sealed class GroupFormation : IMessage<GroupFormation>, IMessage, IEquatable<GroupFormation>, IDeepCloneable<GroupFormation>, IBufferMessage
	{
		// Token: 0x0600A59B RID: 42395 RVA: 0x0018F9D2 File Offset: 0x0018DBD2
		[NullableContext(1)]
		public static GroupFormation Create()
		{
			return new GroupFormation();
		}

		// Token: 0x17002152 RID: 8530
		// (get) Token: 0x0600A59C RID: 42396 RVA: 0x0018F9D9 File Offset: 0x0018DBD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GroupFormation> Parser
		{
			get
			{
				return GroupFormation._parser;
			}
		}

		// Token: 0x17002153 RID: 8531
		// (get) Token: 0x0600A59D RID: 42397 RVA: 0x0018F9E0 File Offset: 0x0018DBE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002154 RID: 8532
		// (get) Token: 0x0600A59E RID: 42398 RVA: 0x0018F9E3 File Offset: 0x0018DBE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GroupFormation.Descriptor;
			}
		}

		// Token: 0x0600A59F RID: 42399 RVA: 0x0018F9EA File Offset: 0x0018DBEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GroupFormation()
		{
		}

		// Token: 0x0600A5A0 RID: 42400 RVA: 0x0018F9FD File Offset: 0x0018DBFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GroupFormation(GroupFormation other) : this()
		{
			this.levelGroup_ = other.levelGroup_;
			this.roleIds_ = other.roleIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A5A1 RID: 42401 RVA: 0x0018FA33 File Offset: 0x0018DC33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GroupFormation Clone()
		{
			return new GroupFormation(this);
		}

		// Token: 0x17002155 RID: 8533
		// (get) Token: 0x0600A5A2 RID: 42402 RVA: 0x0018FA3B File Offset: 0x0018DC3B
		// (set) Token: 0x0600A5A3 RID: 42403 RVA: 0x0018FA43 File Offset: 0x0018DC43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LevelGroup
		{
			get
			{
				return this.levelGroup_;
			}
			set
			{
				this.levelGroup_ = value;
			}
		}

		// Token: 0x17002156 RID: 8534
		// (get) Token: 0x0600A5A4 RID: 42404 RVA: 0x0018FA4C File Offset: 0x0018DC4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RoleIds
		{
			get
			{
				return this.roleIds_;
			}
		}

		// Token: 0x0600A5A5 RID: 42405 RVA: 0x0018FA54 File Offset: 0x0018DC54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GroupFormation);
		}

		// Token: 0x0600A5A6 RID: 42406 RVA: 0x0018FA64 File Offset: 0x0018DC64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GroupFormation other)
		{
			return other != null && (other == this || (this.LevelGroup == other.LevelGroup && this.roleIds_.Equals(other.roleIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A5A7 RID: 42407 RVA: 0x0018FAB4 File Offset: 0x0018DCB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LevelGroup != 0)
			{
				num ^= this.LevelGroup.GetHashCode();
			}
			num ^= this.roleIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A5A8 RID: 42408 RVA: 0x0018FB01 File Offset: 0x0018DD01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A5A9 RID: 42409 RVA: 0x0018FB0E File Offset: 0x0018DD0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A5AA RID: 42410 RVA: 0x0018FB18 File Offset: 0x0018DD18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LevelGroup != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.LevelGroup);
			}
			this.roleIds_.WriteTo(ref output, GroupFormation._repeated_roleIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A5AB RID: 42411 RVA: 0x0018FB68 File Offset: 0x0018DD68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LevelGroup != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LevelGroup);
			}
			num += this.roleIds_.CalculateSize(GroupFormation._repeated_roleIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A5AC RID: 42412 RVA: 0x0018FBBC File Offset: 0x0018DDBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GroupFormation other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LevelGroup != 0)
			{
				this.LevelGroup = other.LevelGroup;
			}
			this.roleIds_.Add(other.roleIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A5AD RID: 42413 RVA: 0x0018FC09 File Offset: 0x0018DE09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A5AE RID: 42414 RVA: 0x0018FC14 File Offset: 0x0018DE14
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
					if (num != 16U && num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.roleIds_.AddEntriesFrom(ref input, GroupFormation._repeated_roleIds_codec);
					}
				}
				else
				{
					this.LevelGroup = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004C22 RID: 19490
		private static readonly MessageParser<GroupFormation> _parser = new MessageParser<GroupFormation>(() => new GroupFormation());

		// Token: 0x04004C23 RID: 19491
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004C24 RID: 19492
		public const int LevelGroupFieldNumber = 1;

		// Token: 0x04004C25 RID: 19493
		private int levelGroup_;

		// Token: 0x04004C26 RID: 19494
		public const int RoleIdsFieldNumber = 2;

		// Token: 0x04004C27 RID: 19495
		private static readonly FieldCodec<int> _repeated_roleIds_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04004C28 RID: 19496
		private readonly RepeatedField<int> roleIds_ = new RepeatedField<int>();
	}
}
