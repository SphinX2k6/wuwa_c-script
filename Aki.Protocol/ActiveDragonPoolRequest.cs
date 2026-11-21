using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000080 RID: 128
	[NetMessage(EMessageId.ActiveDragonPoolRequest)]
	public sealed class ActiveDragonPoolRequest : IMessage<ActiveDragonPoolRequest>, IMessage, IEquatable<ActiveDragonPoolRequest>, IDeepCloneable<ActiveDragonPoolRequest>, IBufferMessage
	{
		// Token: 0x060018EA RID: 6378 RVA: 0x000410AB File Offset: 0x0003F2AB
		[NullableContext(1)]
		public static ActiveDragonPoolRequest Create()
		{
			return new ActiveDragonPoolRequest();
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x060018EB RID: 6379 RVA: 0x000410B2 File Offset: 0x0003F2B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x060018EC RID: 6380 RVA: 0x000410B5 File Offset: 0x0003F2B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActiveDragonPoolRequest.Descriptor;
			}
		}

		// Token: 0x060018ED RID: 6381 RVA: 0x000410BC File Offset: 0x0003F2BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActiveDragonPoolRequest()
		{
		}

		// Token: 0x060018EE RID: 6382 RVA: 0x000410C4 File Offset: 0x0003F2C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActiveDragonPoolRequest(ActiveDragonPoolRequest other) : this()
		{
			this.dragonPoolId_ = other.dragonPoolId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060018EF RID: 6383 RVA: 0x000410E9 File Offset: 0x0003F2E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActiveDragonPoolRequest Clone()
		{
			return new ActiveDragonPoolRequest(this);
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x060018F0 RID: 6384 RVA: 0x000410F1 File Offset: 0x0003F2F1
		// (set) Token: 0x060018F1 RID: 6385 RVA: 0x000410F9 File Offset: 0x0003F2F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DragonPoolId
		{
			get
			{
				return this.dragonPoolId_;
			}
			set
			{
				this.dragonPoolId_ = value;
			}
		}

		// Token: 0x060018F2 RID: 6386 RVA: 0x00041102 File Offset: 0x0003F302
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActiveDragonPoolRequest);
		}

		// Token: 0x060018F3 RID: 6387 RVA: 0x00041110 File Offset: 0x0003F310
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActiveDragonPoolRequest other)
		{
			return other != null && (other == this || (this.DragonPoolId == other.DragonPoolId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060018F4 RID: 6388 RVA: 0x00041140 File Offset: 0x0003F340
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DragonPoolId != 0)
			{
				num ^= this.DragonPoolId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060018F5 RID: 6389 RVA: 0x0004117F File Offset: 0x0003F37F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060018F6 RID: 6390 RVA: 0x0004118C File Offset: 0x0003F38C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060018F7 RID: 6391 RVA: 0x00041195 File Offset: 0x0003F395
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DragonPoolId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.DragonPoolId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060018F8 RID: 6392 RVA: 0x000411C8 File Offset: 0x0003F3C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DragonPoolId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DragonPoolId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060018F9 RID: 6393 RVA: 0x00041206 File Offset: 0x0003F406
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ActiveDragonPoolRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DragonPoolId != 0)
			{
				this.DragonPoolId = other.DragonPoolId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060018FA RID: 6394 RVA: 0x00041237 File Offset: 0x0003F437
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060018FB RID: 6395 RVA: 0x00041240 File Offset: 0x0003F440
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.DragonPoolId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040021EB RID: 8683
		private UnknownFieldSet _unknownFields;

		// Token: 0x040021EC RID: 8684
		public const int DragonPoolIdFieldNumber = 6;

		// Token: 0x040021ED RID: 8685
		private int dragonPoolId_;
	}
}
