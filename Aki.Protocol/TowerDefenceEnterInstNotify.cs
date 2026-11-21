using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001411 RID: 5137
	[NetMessage(EMessageId.TowerDefenceEnterInstNotify)]
	public sealed class TowerDefenceEnterInstNotify : IMessage<TowerDefenceEnterInstNotify>, IMessage, IEquatable<TowerDefenceEnterInstNotify>, IDeepCloneable<TowerDefenceEnterInstNotify>, IBufferMessage
	{
		// Token: 0x0601B4E9 RID: 111849 RVA: 0x003F8B9F File Offset: 0x003F6D9F
		[NullableContext(1)]
		public static TowerDefenceEnterInstNotify Create()
		{
			return new TowerDefenceEnterInstNotify();
		}

		// Token: 0x17005C70 RID: 23664
		// (get) Token: 0x0601B4EA RID: 111850 RVA: 0x003F8BA6 File Offset: 0x003F6DA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005C71 RID: 23665
		// (get) Token: 0x0601B4EB RID: 111851 RVA: 0x003F8BA9 File Offset: 0x003F6DA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerDefenceEnterInstNotify.Descriptor;
			}
		}

		// Token: 0x0601B4EC RID: 111852 RVA: 0x003F8BB0 File Offset: 0x003F6DB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceEnterInstNotify()
		{
		}

		// Token: 0x0601B4ED RID: 111853 RVA: 0x003F8BC3 File Offset: 0x003F6DC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceEnterInstNotify(TowerDefenceEnterInstNotify other) : this()
		{
			this.roleList_ = other.roleList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B4EE RID: 111854 RVA: 0x003F8BED File Offset: 0x003F6DED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceEnterInstNotify Clone()
		{
			return new TowerDefenceEnterInstNotify(this);
		}

		// Token: 0x17005C72 RID: 23666
		// (get) Token: 0x0601B4EF RID: 111855 RVA: 0x003F8BF5 File Offset: 0x003F6DF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TowerDefenceRoleInfo> RoleList
		{
			get
			{
				return this.roleList_;
			}
		}

		// Token: 0x0601B4F0 RID: 111856 RVA: 0x003F8BFD File Offset: 0x003F6DFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerDefenceEnterInstNotify);
		}

		// Token: 0x0601B4F1 RID: 111857 RVA: 0x003F8C0B File Offset: 0x003F6E0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerDefenceEnterInstNotify other)
		{
			return other != null && (other == this || (this.roleList_.Equals(other.roleList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B4F2 RID: 111858 RVA: 0x003F8C40 File Offset: 0x003F6E40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.roleList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B4F3 RID: 111859 RVA: 0x003F8C74 File Offset: 0x003F6E74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B4F4 RID: 111860 RVA: 0x003F8C81 File Offset: 0x003F6E81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B4F5 RID: 111861 RVA: 0x003F8C8A File Offset: 0x003F6E8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.roleList_.WriteTo(ref output, TowerDefenceEnterInstNotify._repeated_roleList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B4F6 RID: 111862 RVA: 0x003F8CB4 File Offset: 0x003F6EB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.roleList_.CalculateSize(TowerDefenceEnterInstNotify._repeated_roleList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B4F7 RID: 111863 RVA: 0x003F8CED File Offset: 0x003F6EED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TowerDefenceEnterInstNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.roleList_.Add(other.roleList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B4F8 RID: 111864 RVA: 0x003F8D1B File Offset: 0x003F6F1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B4F9 RID: 111865 RVA: 0x003F8D24 File Offset: 0x003F6F24
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
				if (num != 34U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.roleList_.AddEntriesFrom(ref input, TowerDefenceEnterInstNotify._repeated_roleList_codec);
				}
			}
		}

		// Token: 0x04009F1A RID: 40730
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009F1B RID: 40731
		public const int RoleListFieldNumber = 4;

		// Token: 0x04009F1C RID: 40732
		private static readonly FieldCodec<TowerDefenceRoleInfo> _repeated_roleList_codec = FieldCodec.ForMessage<TowerDefenceRoleInfo>(34U, TowerDefenceRoleInfo.Parser);

		// Token: 0x04009F1D RID: 40733
		private readonly RepeatedField<TowerDefenceRoleInfo> roleList_ = new RepeatedField<TowerDefenceRoleInfo>();
	}
}
