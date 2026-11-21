using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FB8 RID: 4024
	[NetMessage(EMessageId.RoguelikeWriteCatBossRewardRequest)]
	public sealed class RoguelikeWriteCatBossRewardRequest : IMessage<RoguelikeWriteCatBossRewardRequest>, IMessage, IEquatable<RoguelikeWriteCatBossRewardRequest>, IDeepCloneable<RoguelikeWriteCatBossRewardRequest>, IBufferMessage
	{
		// Token: 0x060158AF RID: 88239 RVA: 0x00321393 File Offset: 0x0031F593
		[NullableContext(1)]
		public static RoguelikeWriteCatBossRewardRequest Create()
		{
			return new RoguelikeWriteCatBossRewardRequest();
		}

		// Token: 0x170047DE RID: 18398
		// (get) Token: 0x060158B0 RID: 88240 RVA: 0x0032139A File Offset: 0x0031F59A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170047DF RID: 18399
		// (get) Token: 0x060158B1 RID: 88241 RVA: 0x0032139D File Offset: 0x0031F59D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeWriteCatBossRewardRequest.Descriptor;
			}
		}

		// Token: 0x060158B2 RID: 88242 RVA: 0x003213A4 File Offset: 0x0031F5A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeWriteCatBossRewardRequest()
		{
		}

		// Token: 0x060158B3 RID: 88243 RVA: 0x003213AC File Offset: 0x0031F5AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeWriteCatBossRewardRequest(RoguelikeWriteCatBossRewardRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.index_ = other.index_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060158B4 RID: 88244 RVA: 0x003213DD File Offset: 0x0031F5DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeWriteCatBossRewardRequest Clone()
		{
			return new RoguelikeWriteCatBossRewardRequest(this);
		}

		// Token: 0x170047E0 RID: 18400
		// (get) Token: 0x060158B5 RID: 88245 RVA: 0x003213E5 File Offset: 0x0031F5E5
		// (set) Token: 0x060158B6 RID: 88246 RVA: 0x003213ED File Offset: 0x0031F5ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x170047E1 RID: 18401
		// (get) Token: 0x060158B7 RID: 88247 RVA: 0x003213F6 File Offset: 0x0031F5F6
		// (set) Token: 0x060158B8 RID: 88248 RVA: 0x003213FE File Offset: 0x0031F5FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Index
		{
			get
			{
				return this.index_;
			}
			set
			{
				this.index_ = value;
			}
		}

		// Token: 0x060158B9 RID: 88249 RVA: 0x00321407 File Offset: 0x0031F607
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeWriteCatBossRewardRequest);
		}

		// Token: 0x060158BA RID: 88250 RVA: 0x00321415 File Offset: 0x0031F615
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeWriteCatBossRewardRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.Index == other.Index && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060158BB RID: 88251 RVA: 0x00321454 File Offset: 0x0031F654
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.Index != 0)
			{
				num ^= this.Index.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060158BC RID: 88252 RVA: 0x003214AC File Offset: 0x0031F6AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060158BD RID: 88253 RVA: 0x003214B9 File Offset: 0x0031F6B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060158BE RID: 88254 RVA: 0x003214C4 File Offset: 0x0031F6C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.ActivityId);
			}
			if (this.Index != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.Index);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060158BF RID: 88255 RVA: 0x00321520 File Offset: 0x0031F720
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.Index != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Index);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060158C0 RID: 88256 RVA: 0x00321578 File Offset: 0x0031F778
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoguelikeWriteCatBossRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.Index != 0)
			{
				this.Index = other.Index;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060158C1 RID: 88257 RVA: 0x003215C8 File Offset: 0x0031F7C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060158C2 RID: 88258 RVA: 0x003215D4 File Offset: 0x0031F7D4
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
				if (num != 56U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Index = input.ReadInt32();
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040081EC RID: 33260
		private UnknownFieldSet _unknownFields;

		// Token: 0x040081ED RID: 33261
		public const int ActivityIdFieldNumber = 7;

		// Token: 0x040081EE RID: 33262
		private int activityId_;

		// Token: 0x040081EF RID: 33263
		public const int IndexFieldNumber = 15;

		// Token: 0x040081F0 RID: 33264
		private int index_;
	}
}
