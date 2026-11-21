using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001209 RID: 4617
	[NetMessage(EMessageId.SetFanNumberOfTurnsRequest)]
	public sealed class SetFanNumberOfTurnsRequest : IMessage<SetFanNumberOfTurnsRequest>, IMessage, IEquatable<SetFanNumberOfTurnsRequest>, IDeepCloneable<SetFanNumberOfTurnsRequest>, IBufferMessage
	{
		// Token: 0x06018AB1 RID: 101041 RVA: 0x00399041 File Offset: 0x00397241
		[NullableContext(1)]
		public static SetFanNumberOfTurnsRequest Create()
		{
			return new SetFanNumberOfTurnsRequest();
		}

		// Token: 0x17005351 RID: 21329
		// (get) Token: 0x06018AB2 RID: 101042 RVA: 0x00399048 File Offset: 0x00397248
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005352 RID: 21330
		// (get) Token: 0x06018AB3 RID: 101043 RVA: 0x0039904B File Offset: 0x0039724B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetFanNumberOfTurnsRequest.Descriptor;
			}
		}

		// Token: 0x06018AB4 RID: 101044 RVA: 0x00399052 File Offset: 0x00397252
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetFanNumberOfTurnsRequest()
		{
		}

		// Token: 0x06018AB5 RID: 101045 RVA: 0x0039905A File Offset: 0x0039725A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetFanNumberOfTurnsRequest(SetFanNumberOfTurnsRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this.numberOfTurns_ = other.numberOfTurns_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018AB6 RID: 101046 RVA: 0x0039908B File Offset: 0x0039728B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetFanNumberOfTurnsRequest Clone()
		{
			return new SetFanNumberOfTurnsRequest(this);
		}

		// Token: 0x17005353 RID: 21331
		// (get) Token: 0x06018AB7 RID: 101047 RVA: 0x00399093 File Offset: 0x00397293
		// (set) Token: 0x06018AB8 RID: 101048 RVA: 0x0039909B File Offset: 0x0039729B
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

		// Token: 0x17005354 RID: 21332
		// (get) Token: 0x06018AB9 RID: 101049 RVA: 0x003990A4 File Offset: 0x003972A4
		// (set) Token: 0x06018ABA RID: 101050 RVA: 0x003990AC File Offset: 0x003972AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int NumberOfTurns
		{
			get
			{
				return this.numberOfTurns_;
			}
			set
			{
				this.numberOfTurns_ = value;
			}
		}

		// Token: 0x06018ABB RID: 101051 RVA: 0x003990B5 File Offset: 0x003972B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetFanNumberOfTurnsRequest);
		}

		// Token: 0x06018ABC RID: 101052 RVA: 0x003990C3 File Offset: 0x003972C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetFanNumberOfTurnsRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.NumberOfTurns == other.NumberOfTurns && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018ABD RID: 101053 RVA: 0x00399104 File Offset: 0x00397304
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.NumberOfTurns != 0)
			{
				num ^= this.NumberOfTurns.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018ABE RID: 101054 RVA: 0x0039915C File Offset: 0x0039735C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018ABF RID: 101055 RVA: 0x00399169 File Offset: 0x00397369
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018AC0 RID: 101056 RVA: 0x00399174 File Offset: 0x00397374
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(104);
				output.WriteInt64(this.EntityId);
			}
			if (this.NumberOfTurns != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.NumberOfTurns);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018AC1 RID: 101057 RVA: 0x003991D0 File Offset: 0x003973D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.NumberOfTurns != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.NumberOfTurns);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018AC2 RID: 101058 RVA: 0x00399228 File Offset: 0x00397428
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SetFanNumberOfTurnsRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.NumberOfTurns != 0)
			{
				this.NumberOfTurns = other.NumberOfTurns;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018AC3 RID: 101059 RVA: 0x00399278 File Offset: 0x00397478
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018AC4 RID: 101060 RVA: 0x00399284 File Offset: 0x00397484
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
				if (num != 104U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.NumberOfTurns = input.ReadInt32();
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04009292 RID: 37522
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009293 RID: 37523
		public const int EntityIdFieldNumber = 13;

		// Token: 0x04009294 RID: 37524
		private long entityId_;

		// Token: 0x04009295 RID: 37525
		public const int NumberOfTurnsFieldNumber = 14;

		// Token: 0x04009296 RID: 37526
		private int numberOfTurns_;
	}
}
