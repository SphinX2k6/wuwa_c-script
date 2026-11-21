using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009C2 RID: 2498
	public sealed class MingSuGenInfo : IMessage<MingSuGenInfo>, IMessage, IEquatable<MingSuGenInfo>, IDeepCloneable<MingSuGenInfo>, IBufferMessage
	{
		// Token: 0x0600DB75 RID: 56181 RVA: 0x00204001 File Offset: 0x00202201
		[NullableContext(1)]
		public static MingSuGenInfo Create()
		{
			return new MingSuGenInfo();
		}

		// Token: 0x17002C78 RID: 11384
		// (get) Token: 0x0600DB76 RID: 56182 RVA: 0x00204008 File Offset: 0x00202208
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MingSuGenInfo> Parser
		{
			get
			{
				return MingSuGenInfo._parser;
			}
		}

		// Token: 0x17002C79 RID: 11385
		// (get) Token: 0x0600DB77 RID: 56183 RVA: 0x0020400F File Offset: 0x0020220F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002C7A RID: 11386
		// (get) Token: 0x0600DB78 RID: 56184 RVA: 0x00204012 File Offset: 0x00202212
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MingSuGenInfo.Descriptor;
			}
		}

		// Token: 0x0600DB79 RID: 56185 RVA: 0x00204019 File Offset: 0x00202219
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MingSuGenInfo()
		{
		}

		// Token: 0x0600DB7A RID: 56186 RVA: 0x00204021 File Offset: 0x00202221
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MingSuGenInfo(MingSuGenInfo other) : this()
		{
			this.creatureGenID_ = other.creatureGenID_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DB7B RID: 56187 RVA: 0x00204046 File Offset: 0x00202246
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MingSuGenInfo Clone()
		{
			return new MingSuGenInfo(this);
		}

		// Token: 0x17002C7B RID: 11387
		// (get) Token: 0x0600DB7C RID: 56188 RVA: 0x0020404E File Offset: 0x0020224E
		// (set) Token: 0x0600DB7D RID: 56189 RVA: 0x00204056 File Offset: 0x00202256
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long CreatureGenID
		{
			get
			{
				return this.creatureGenID_;
			}
			set
			{
				this.creatureGenID_ = value;
			}
		}

		// Token: 0x0600DB7E RID: 56190 RVA: 0x0020405F File Offset: 0x0020225F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MingSuGenInfo);
		}

		// Token: 0x0600DB7F RID: 56191 RVA: 0x0020406D File Offset: 0x0020226D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MingSuGenInfo other)
		{
			return other != null && (other == this || (this.CreatureGenID == other.CreatureGenID && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DB80 RID: 56192 RVA: 0x0020409C File Offset: 0x0020229C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CreatureGenID != 0L)
			{
				num ^= this.CreatureGenID.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DB81 RID: 56193 RVA: 0x002040DB File Offset: 0x002022DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DB82 RID: 56194 RVA: 0x002040E8 File Offset: 0x002022E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DB83 RID: 56195 RVA: 0x002040F1 File Offset: 0x002022F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CreatureGenID != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.CreatureGenID);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DB84 RID: 56196 RVA: 0x00204124 File Offset: 0x00202324
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CreatureGenID != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.CreatureGenID);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DB85 RID: 56197 RVA: 0x00204162 File Offset: 0x00202362
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MingSuGenInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CreatureGenID != 0L)
			{
				this.CreatureGenID = other.CreatureGenID;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DB86 RID: 56198 RVA: 0x00204193 File Offset: 0x00202393
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DB87 RID: 56199 RVA: 0x0020419C File Offset: 0x0020239C
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.CreatureGenID = input.ReadInt64();
				}
			}
		}

		// Token: 0x04005B65 RID: 23397
		private static readonly MessageParser<MingSuGenInfo> _parser = new MessageParser<MingSuGenInfo>(() => new MingSuGenInfo());

		// Token: 0x04005B66 RID: 23398
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005B67 RID: 23399
		public const int CreatureGenIDFieldNumber = 1;

		// Token: 0x04005B68 RID: 23400
		private long creatureGenID_;
	}
}
