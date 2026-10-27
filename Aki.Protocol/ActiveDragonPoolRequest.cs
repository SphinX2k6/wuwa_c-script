using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200007F RID: 127
	[NetMessage(EMessageId.ActiveDragonPoolRequest)]
	public sealed class ActiveDragonPoolRequest : IMessage<ActiveDragonPoolRequest>, IMessage, IEquatable<ActiveDragonPoolRequest>, IDeepCloneable<ActiveDragonPoolRequest>, IBufferMessage
	{
		// Token: 0x060018A7 RID: 6311 RVA: 0x000406FB File Offset: 0x0003E8FB
		[NullableContext(1)]
		public static ActiveDragonPoolRequest Create()
		{
			return new ActiveDragonPoolRequest();
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x060018A8 RID: 6312 RVA: 0x00040702 File Offset: 0x0003E902
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x060018A9 RID: 6313 RVA: 0x00040705 File Offset: 0x0003E905
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActiveDragonPoolRequest.Descriptor;
			}
		}

		// Token: 0x060018AA RID: 6314 RVA: 0x0004070C File Offset: 0x0003E90C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActiveDragonPoolRequest()
		{
		}

		// Token: 0x060018AB RID: 6315 RVA: 0x00040714 File Offset: 0x0003E914
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActiveDragonPoolRequest(ActiveDragonPoolRequest other) : this()
		{
			this.dragonPoolId_ = other.dragonPoolId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060018AC RID: 6316 RVA: 0x00040739 File Offset: 0x0003E939
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActiveDragonPoolRequest Clone()
		{
			return new ActiveDragonPoolRequest(this);
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x060018AD RID: 6317 RVA: 0x00040741 File Offset: 0x0003E941
		// (set) Token: 0x060018AE RID: 6318 RVA: 0x00040749 File Offset: 0x0003E949
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

		// Token: 0x060018AF RID: 6319 RVA: 0x00040752 File Offset: 0x0003E952
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActiveDragonPoolRequest);
		}

		// Token: 0x060018B0 RID: 6320 RVA: 0x00040760 File Offset: 0x0003E960
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActiveDragonPoolRequest other)
		{
			return other != null && (other == this || (this.DragonPoolId == other.DragonPoolId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060018B1 RID: 6321 RVA: 0x00040790 File Offset: 0x0003E990
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

		// Token: 0x060018B2 RID: 6322 RVA: 0x000407CF File Offset: 0x0003E9CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060018B3 RID: 6323 RVA: 0x000407DC File Offset: 0x0003E9DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060018B4 RID: 6324 RVA: 0x000407E5 File Offset: 0x0003E9E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DragonPoolId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.DragonPoolId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060018B5 RID: 6325 RVA: 0x00040818 File Offset: 0x0003EA18
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

		// Token: 0x060018B6 RID: 6326 RVA: 0x00040856 File Offset: 0x0003EA56
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

		// Token: 0x060018B7 RID: 6327 RVA: 0x00040887 File Offset: 0x0003EA87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060018B8 RID: 6328 RVA: 0x00040890 File Offset: 0x0003EA90
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.DragonPoolId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400218C RID: 8588
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400218D RID: 8589
		public const int DragonPoolIdFieldNumber = 9;

		// Token: 0x0400218E RID: 8590
		private int dragonPoolId_;
	}
}
