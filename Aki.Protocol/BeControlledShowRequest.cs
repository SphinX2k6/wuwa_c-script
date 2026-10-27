using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200018F RID: 399
	[NetMessage(EMessageId.BeControlledShowRequest)]
	public sealed class BeControlledShowRequest : IMessage<BeControlledShowRequest>, IMessage, IEquatable<BeControlledShowRequest>, IDeepCloneable<BeControlledShowRequest>, IBufferMessage
	{
		// Token: 0x06002FAD RID: 12205 RVA: 0x0007A0D6 File Offset: 0x000782D6
		[NullableContext(1)]
		public static BeControlledShowRequest Create()
		{
			return new BeControlledShowRequest();
		}

		// Token: 0x17000752 RID: 1874
		// (get) Token: 0x06002FAE RID: 12206 RVA: 0x0007A0DD File Offset: 0x000782DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000753 RID: 1875
		// (get) Token: 0x06002FAF RID: 12207 RVA: 0x0007A0E0 File Offset: 0x000782E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BeControlledShowRequest.Descriptor;
			}
		}

		// Token: 0x06002FB0 RID: 12208 RVA: 0x0007A0E7 File Offset: 0x000782E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeControlledShowRequest()
		{
		}

		// Token: 0x06002FB1 RID: 12209 RVA: 0x0007A0EF File Offset: 0x000782EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeControlledShowRequest(BeControlledShowRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this.isShow_ = other.isShow_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002FB2 RID: 12210 RVA: 0x0007A120 File Offset: 0x00078320
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeControlledShowRequest Clone()
		{
			return new BeControlledShowRequest(this);
		}

		// Token: 0x17000754 RID: 1876
		// (get) Token: 0x06002FB3 RID: 12211 RVA: 0x0007A128 File Offset: 0x00078328
		// (set) Token: 0x06002FB4 RID: 12212 RVA: 0x0007A130 File Offset: 0x00078330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x17000755 RID: 1877
		// (get) Token: 0x06002FB5 RID: 12213 RVA: 0x0007A139 File Offset: 0x00078339
		// (set) Token: 0x06002FB6 RID: 12214 RVA: 0x0007A141 File Offset: 0x00078341
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsShow
		{
			get
			{
				return this.isShow_;
			}
			set
			{
				this.isShow_ = value;
			}
		}

		// Token: 0x06002FB7 RID: 12215 RVA: 0x0007A14A File Offset: 0x0007834A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BeControlledShowRequest);
		}

		// Token: 0x06002FB8 RID: 12216 RVA: 0x0007A158 File Offset: 0x00078358
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BeControlledShowRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.IsShow == other.IsShow && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002FB9 RID: 12217 RVA: 0x0007A198 File Offset: 0x00078398
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.IsShow)
			{
				num ^= this.IsShow.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002FBA RID: 12218 RVA: 0x0007A1F0 File Offset: 0x000783F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002FBB RID: 12219 RVA: 0x0007A1FD File Offset: 0x000783FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002FBC RID: 12220 RVA: 0x0007A208 File Offset: 0x00078408
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.EntityId);
			}
			if (this.IsShow)
			{
				output.WriteRawTag(112);
				output.WriteBool(this.IsShow);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002FBD RID: 12221 RVA: 0x0007A264 File Offset: 0x00078464
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.IsShow)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002FBE RID: 12222 RVA: 0x0007A2B0 File Offset: 0x000784B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BeControlledShowRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.IsShow)
			{
				this.IsShow = other.IsShow;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002FBF RID: 12223 RVA: 0x0007A300 File Offset: 0x00078500
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002FC0 RID: 12224 RVA: 0x0007A30C File Offset: 0x0007850C
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
				if (num != 40U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.IsShow = input.ReadBool();
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x040028C1 RID: 10433
		private UnknownFieldSet _unknownFields;

		// Token: 0x040028C2 RID: 10434
		public const int EntityIdFieldNumber = 5;

		// Token: 0x040028C3 RID: 10435
		private long entityId_;

		// Token: 0x040028C4 RID: 10436
		public const int IsShowFieldNumber = 14;

		// Token: 0x040028C5 RID: 10437
		private bool isShow_;
	}
}
