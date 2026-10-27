using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200107F RID: 4223
	public sealed class RoleGiftActivityData : IMessage<RoleGiftActivityData>, IMessage, IEquatable<RoleGiftActivityData>, IDeepCloneable<RoleGiftActivityData>, IBufferMessage
	{
		// Token: 0x060168FA RID: 92410 RVA: 0x003477A7 File Offset: 0x003459A7
		[NullableContext(1)]
		public static RoleGiftActivityData Create()
		{
			return new RoleGiftActivityData();
		}

		// Token: 0x17004B89 RID: 19337
		// (get) Token: 0x060168FB RID: 92411 RVA: 0x003477AE File Offset: 0x003459AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004B8A RID: 19338
		// (get) Token: 0x060168FC RID: 92412 RVA: 0x003477B1 File Offset: 0x003459B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleGiftActivityData.Descriptor;
			}
		}

		// Token: 0x060168FD RID: 92413 RVA: 0x003477B8 File Offset: 0x003459B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleGiftActivityData()
		{
		}

		// Token: 0x060168FE RID: 92414 RVA: 0x003477C0 File Offset: 0x003459C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleGiftActivityData(RoleGiftActivityData other) : this()
		{
			this.rewardHadGet_ = other.rewardHadGet_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060168FF RID: 92415 RVA: 0x003477E5 File Offset: 0x003459E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleGiftActivityData Clone()
		{
			return new RoleGiftActivityData(this);
		}

		// Token: 0x17004B8B RID: 19339
		// (get) Token: 0x06016900 RID: 92416 RVA: 0x003477ED File Offset: 0x003459ED
		// (set) Token: 0x06016901 RID: 92417 RVA: 0x003477F5 File Offset: 0x003459F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool RewardHadGet
		{
			get
			{
				return this.rewardHadGet_;
			}
			set
			{
				this.rewardHadGet_ = value;
			}
		}

		// Token: 0x06016902 RID: 92418 RVA: 0x003477FE File Offset: 0x003459FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleGiftActivityData);
		}

		// Token: 0x06016903 RID: 92419 RVA: 0x0034780C File Offset: 0x00345A0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleGiftActivityData other)
		{
			return other != null && (other == this || (this.RewardHadGet == other.RewardHadGet && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016904 RID: 92420 RVA: 0x0034783C File Offset: 0x00345A3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RewardHadGet)
			{
				num ^= this.RewardHadGet.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016905 RID: 92421 RVA: 0x0034787B File Offset: 0x00345A7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016906 RID: 92422 RVA: 0x00347888 File Offset: 0x00345A88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016907 RID: 92423 RVA: 0x00347891 File Offset: 0x00345A91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RewardHadGet)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.RewardHadGet);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016908 RID: 92424 RVA: 0x003478C4 File Offset: 0x00345AC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RewardHadGet)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016909 RID: 92425 RVA: 0x003478F6 File Offset: 0x00345AF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleGiftActivityData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RewardHadGet)
			{
				this.RewardHadGet = other.RewardHadGet;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601690A RID: 92426 RVA: 0x00347927 File Offset: 0x00345B27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601690B RID: 92427 RVA: 0x00347930 File Offset: 0x00345B30
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
					this.RewardHadGet = input.ReadBool();
				}
			}
		}

		// Token: 0x040086D6 RID: 34518
		private UnknownFieldSet _unknownFields;

		// Token: 0x040086D7 RID: 34519
		public const int RewardHadGetFieldNumber = 1;

		// Token: 0x040086D8 RID: 34520
		private bool rewardHadGet_;
	}
}
