using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200053F RID: 1343
	[NetMessage(EMessageId.FirecrackerEntityCreatedNotify)]
	public sealed class FirecrackerEntityCreatedNotify : IMessage<FirecrackerEntityCreatedNotify>, IMessage, IEquatable<FirecrackerEntityCreatedNotify>, IDeepCloneable<FirecrackerEntityCreatedNotify>, IBufferMessage
	{
		// Token: 0x06007DC7 RID: 32199 RVA: 0x00130BB5 File Offset: 0x0012EDB5
		[NullableContext(1)]
		public static FirecrackerEntityCreatedNotify Create()
		{
			return new FirecrackerEntityCreatedNotify();
		}

		// Token: 0x1700187A RID: 6266
		// (get) Token: 0x06007DC8 RID: 32200 RVA: 0x00130BBC File Offset: 0x0012EDBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700187B RID: 6267
		// (get) Token: 0x06007DC9 RID: 32201 RVA: 0x00130BBF File Offset: 0x0012EDBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FirecrackerEntityCreatedNotify.Descriptor;
			}
		}

		// Token: 0x06007DCA RID: 32202 RVA: 0x00130BC6 File Offset: 0x0012EDC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FirecrackerEntityCreatedNotify()
		{
		}

		// Token: 0x06007DCB RID: 32203 RVA: 0x00130BCE File Offset: 0x0012EDCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FirecrackerEntityCreatedNotify(FirecrackerEntityCreatedNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007DCC RID: 32204 RVA: 0x00130BF3 File Offset: 0x0012EDF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FirecrackerEntityCreatedNotify Clone()
		{
			return new FirecrackerEntityCreatedNotify(this);
		}

		// Token: 0x1700187C RID: 6268
		// (get) Token: 0x06007DCD RID: 32205 RVA: 0x00130BFB File Offset: 0x0012EDFB
		// (set) Token: 0x06007DCE RID: 32206 RVA: 0x00130C03 File Offset: 0x0012EE03
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

		// Token: 0x06007DCF RID: 32207 RVA: 0x00130C0C File Offset: 0x0012EE0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FirecrackerEntityCreatedNotify);
		}

		// Token: 0x06007DD0 RID: 32208 RVA: 0x00130C1A File Offset: 0x0012EE1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FirecrackerEntityCreatedNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007DD1 RID: 32209 RVA: 0x00130C48 File Offset: 0x0012EE48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007DD2 RID: 32210 RVA: 0x00130C87 File Offset: 0x0012EE87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007DD3 RID: 32211 RVA: 0x00130C94 File Offset: 0x0012EE94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007DD4 RID: 32212 RVA: 0x00130C9D File Offset: 0x0012EE9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(88);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007DD5 RID: 32213 RVA: 0x00130CD0 File Offset: 0x0012EED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007DD6 RID: 32214 RVA: 0x00130D0E File Offset: 0x0012EF0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FirecrackerEntityCreatedNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007DD7 RID: 32215 RVA: 0x00130D3F File Offset: 0x0012EF3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007DD8 RID: 32216 RVA: 0x00130D48 File Offset: 0x0012EF48
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04003FEE RID: 16366
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003FEF RID: 16367
		public const int EntityIdFieldNumber = 11;

		// Token: 0x04003FF0 RID: 16368
		private long entityId_;
	}
}
