using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011F6 RID: 4598
	[NetMessage(EMessageId.SelectBabelActivityDeTermRequest)]
	public sealed class SelectBabelActivityDeTermRequest : IMessage<SelectBabelActivityDeTermRequest>, IMessage, IEquatable<SelectBabelActivityDeTermRequest>, IDeepCloneable<SelectBabelActivityDeTermRequest>, IBufferMessage
	{
		// Token: 0x06018941 RID: 100673 RVA: 0x00396197 File Offset: 0x00394397
		[NullableContext(1)]
		public static SelectBabelActivityDeTermRequest Create()
		{
			return new SelectBabelActivityDeTermRequest();
		}

		// Token: 0x1700530B RID: 21259
		// (get) Token: 0x06018942 RID: 100674 RVA: 0x0039619E File Offset: 0x0039439E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700530C RID: 21260
		// (get) Token: 0x06018943 RID: 100675 RVA: 0x003961A1 File Offset: 0x003943A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SelectBabelActivityDeTermRequest.Descriptor;
			}
		}

		// Token: 0x06018944 RID: 100676 RVA: 0x003961A8 File Offset: 0x003943A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SelectBabelActivityDeTermRequest()
		{
		}

		// Token: 0x06018945 RID: 100677 RVA: 0x003961BB File Offset: 0x003943BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SelectBabelActivityDeTermRequest(SelectBabelActivityDeTermRequest other) : this()
		{
			this.babelTowerLevelId_ = other.babelTowerLevelId_;
			this.babelDeTermId_ = other.babelDeTermId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018946 RID: 100678 RVA: 0x003961F1 File Offset: 0x003943F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SelectBabelActivityDeTermRequest Clone()
		{
			return new SelectBabelActivityDeTermRequest(this);
		}

		// Token: 0x1700530D RID: 21261
		// (get) Token: 0x06018947 RID: 100679 RVA: 0x003961F9 File Offset: 0x003943F9
		// (set) Token: 0x06018948 RID: 100680 RVA: 0x00396201 File Offset: 0x00394401
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BabelTowerLevelId
		{
			get
			{
				return this.babelTowerLevelId_;
			}
			set
			{
				this.babelTowerLevelId_ = value;
			}
		}

		// Token: 0x1700530E RID: 21262
		// (get) Token: 0x06018949 RID: 100681 RVA: 0x0039620A File Offset: 0x0039440A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> BabelDeTermId
		{
			get
			{
				return this.babelDeTermId_;
			}
		}

		// Token: 0x0601894A RID: 100682 RVA: 0x00396212 File Offset: 0x00394412
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SelectBabelActivityDeTermRequest);
		}

		// Token: 0x0601894B RID: 100683 RVA: 0x00396220 File Offset: 0x00394420
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SelectBabelActivityDeTermRequest other)
		{
			return other != null && (other == this || (this.BabelTowerLevelId == other.BabelTowerLevelId && this.babelDeTermId_.Equals(other.babelDeTermId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601894C RID: 100684 RVA: 0x00396270 File Offset: 0x00394470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BabelTowerLevelId != 0)
			{
				num ^= this.BabelTowerLevelId.GetHashCode();
			}
			num ^= this.babelDeTermId_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601894D RID: 100685 RVA: 0x003962BD File Offset: 0x003944BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601894E RID: 100686 RVA: 0x003962CA File Offset: 0x003944CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601894F RID: 100687 RVA: 0x003962D4 File Offset: 0x003944D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BabelTowerLevelId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.BabelTowerLevelId);
			}
			this.babelDeTermId_.WriteTo(ref output, SelectBabelActivityDeTermRequest._repeated_babelDeTermId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018950 RID: 100688 RVA: 0x00396324 File Offset: 0x00394524
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BabelTowerLevelId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BabelTowerLevelId);
			}
			num += this.babelDeTermId_.CalculateSize(SelectBabelActivityDeTermRequest._repeated_babelDeTermId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018951 RID: 100689 RVA: 0x00396378 File Offset: 0x00394578
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SelectBabelActivityDeTermRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BabelTowerLevelId != 0)
			{
				this.BabelTowerLevelId = other.BabelTowerLevelId;
			}
			this.babelDeTermId_.Add(other.babelDeTermId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018952 RID: 100690 RVA: 0x003963C5 File Offset: 0x003945C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018953 RID: 100691 RVA: 0x003963D0 File Offset: 0x003945D0
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
					if (num != 96U && num != 98U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.babelDeTermId_.AddEntriesFrom(ref input, SelectBabelActivityDeTermRequest._repeated_babelDeTermId_codec);
					}
				}
				else
				{
					this.BabelTowerLevelId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400923E RID: 37438
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400923F RID: 37439
		public const int BabelTowerLevelIdFieldNumber = 7;

		// Token: 0x04009240 RID: 37440
		private int babelTowerLevelId_;

		// Token: 0x04009241 RID: 37441
		public const int BabelDeTermIdFieldNumber = 12;

		// Token: 0x04009242 RID: 37442
		private static readonly FieldCodec<int> _repeated_babelDeTermId_codec = FieldCodec.ForInt32(98U);

		// Token: 0x04009243 RID: 37443
		private readonly RepeatedField<int> babelDeTermId_ = new RepeatedField<int>();
	}
}
