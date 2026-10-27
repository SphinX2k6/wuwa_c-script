using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001396 RID: 5014
	[NetMessage(EMessageId.TowerApplyFloorDataRequest)]
	public sealed class TowerApplyFloorDataRequest : IMessage<TowerApplyFloorDataRequest>, IMessage, IEquatable<TowerApplyFloorDataRequest>, IDeepCloneable<TowerApplyFloorDataRequest>, IBufferMessage
	{
		// Token: 0x0601A9B2 RID: 108978 RVA: 0x003DC09D File Offset: 0x003DA29D
		[NullableContext(1)]
		public static TowerApplyFloorDataRequest Create()
		{
			return new TowerApplyFloorDataRequest();
		}

		// Token: 0x170059B4 RID: 22964
		// (get) Token: 0x0601A9B3 RID: 108979 RVA: 0x003DC0A4 File Offset: 0x003DA2A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170059B5 RID: 22965
		// (get) Token: 0x0601A9B4 RID: 108980 RVA: 0x003DC0A7 File Offset: 0x003DA2A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerApplyFloorDataRequest.Descriptor;
			}
		}

		// Token: 0x0601A9B5 RID: 108981 RVA: 0x003DC0AE File Offset: 0x003DA2AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerApplyFloorDataRequest()
		{
		}

		// Token: 0x0601A9B6 RID: 108982 RVA: 0x003DC0B6 File Offset: 0x003DA2B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerApplyFloorDataRequest(TowerApplyFloorDataRequest other) : this()
		{
			this.apply_ = other.apply_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A9B7 RID: 108983 RVA: 0x003DC0DB File Offset: 0x003DA2DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerApplyFloorDataRequest Clone()
		{
			return new TowerApplyFloorDataRequest(this);
		}

		// Token: 0x170059B6 RID: 22966
		// (get) Token: 0x0601A9B8 RID: 108984 RVA: 0x003DC0E3 File Offset: 0x003DA2E3
		// (set) Token: 0x0601A9B9 RID: 108985 RVA: 0x003DC0EB File Offset: 0x003DA2EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Apply
		{
			get
			{
				return this.apply_;
			}
			set
			{
				this.apply_ = value;
			}
		}

		// Token: 0x0601A9BA RID: 108986 RVA: 0x003DC0F4 File Offset: 0x003DA2F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerApplyFloorDataRequest);
		}

		// Token: 0x0601A9BB RID: 108987 RVA: 0x003DC102 File Offset: 0x003DA302
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerApplyFloorDataRequest other)
		{
			return other != null && (other == this || (this.Apply == other.Apply && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A9BC RID: 108988 RVA: 0x003DC130 File Offset: 0x003DA330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Apply)
			{
				num ^= this.Apply.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A9BD RID: 108989 RVA: 0x003DC16F File Offset: 0x003DA36F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A9BE RID: 108990 RVA: 0x003DC17C File Offset: 0x003DA37C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A9BF RID: 108991 RVA: 0x003DC185 File Offset: 0x003DA385
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Apply)
			{
				output.WriteRawTag(112);
				output.WriteBool(this.Apply);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A9C0 RID: 108992 RVA: 0x003DC1B8 File Offset: 0x003DA3B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Apply)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A9C1 RID: 108993 RVA: 0x003DC1EA File Offset: 0x003DA3EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TowerApplyFloorDataRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Apply)
			{
				this.Apply = other.Apply;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A9C2 RID: 108994 RVA: 0x003DC21B File Offset: 0x003DA41B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A9C3 RID: 108995 RVA: 0x003DC224 File Offset: 0x003DA424
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Apply = input.ReadBool();
				}
			}
		}

		// Token: 0x04009A9B RID: 39579
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009A9C RID: 39580
		public const int ApplyFieldNumber = 14;

		// Token: 0x04009A9D RID: 39581
		private bool apply_;
	}
}
