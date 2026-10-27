using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200139E RID: 5022
	[NetMessage(EMessageId.TowerDefenceEnterInstNotify)]
	public sealed class TowerDefenceEnterInstNotify : IMessage<TowerDefenceEnterInstNotify>, IMessage, IEquatable<TowerDefenceEnterInstNotify>, IDeepCloneable<TowerDefenceEnterInstNotify>, IBufferMessage
	{
		// Token: 0x0601AA5E RID: 109150 RVA: 0x003DD8D6 File Offset: 0x003DBAD6
		[NullableContext(1)]
		public static TowerDefenceEnterInstNotify Create()
		{
			return new TowerDefenceEnterInstNotify();
		}

		// Token: 0x170059DB RID: 23003
		// (get) Token: 0x0601AA5F RID: 109151 RVA: 0x003DD8DD File Offset: 0x003DBADD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170059DC RID: 23004
		// (get) Token: 0x0601AA60 RID: 109152 RVA: 0x003DD8E0 File Offset: 0x003DBAE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerDefenceEnterInstNotify.Descriptor;
			}
		}

		// Token: 0x0601AA61 RID: 109153 RVA: 0x003DD8E7 File Offset: 0x003DBAE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceEnterInstNotify()
		{
		}

		// Token: 0x0601AA62 RID: 109154 RVA: 0x003DD8FA File Offset: 0x003DBAFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceEnterInstNotify(TowerDefenceEnterInstNotify other) : this()
		{
			this.roleList_ = other.roleList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AA63 RID: 109155 RVA: 0x003DD924 File Offset: 0x003DBB24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceEnterInstNotify Clone()
		{
			return new TowerDefenceEnterInstNotify(this);
		}

		// Token: 0x170059DD RID: 23005
		// (get) Token: 0x0601AA64 RID: 109156 RVA: 0x003DD92C File Offset: 0x003DBB2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TowerDefenceRoleInfo> RoleList
		{
			get
			{
				return this.roleList_;
			}
		}

		// Token: 0x0601AA65 RID: 109157 RVA: 0x003DD934 File Offset: 0x003DBB34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerDefenceEnterInstNotify);
		}

		// Token: 0x0601AA66 RID: 109158 RVA: 0x003DD942 File Offset: 0x003DBB42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerDefenceEnterInstNotify other)
		{
			return other != null && (other == this || (this.roleList_.Equals(other.roleList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AA67 RID: 109159 RVA: 0x003DD978 File Offset: 0x003DBB78
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

		// Token: 0x0601AA68 RID: 109160 RVA: 0x003DD9AC File Offset: 0x003DBBAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AA69 RID: 109161 RVA: 0x003DD9B9 File Offset: 0x003DBBB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AA6A RID: 109162 RVA: 0x003DD9C2 File Offset: 0x003DBBC2
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

		// Token: 0x0601AA6B RID: 109163 RVA: 0x003DD9EC File Offset: 0x003DBBEC
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

		// Token: 0x0601AA6C RID: 109164 RVA: 0x003DDA25 File Offset: 0x003DBC25
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

		// Token: 0x0601AA6D RID: 109165 RVA: 0x003DDA53 File Offset: 0x003DBC53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AA6E RID: 109166 RVA: 0x003DDA5C File Offset: 0x003DBC5C
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
				if (num != 50U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.roleList_.AddEntriesFrom(ref input, TowerDefenceEnterInstNotify._repeated_roleList_codec);
				}
			}
		}

		// Token: 0x04009AD3 RID: 39635
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009AD4 RID: 39636
		public const int RoleListFieldNumber = 6;

		// Token: 0x04009AD5 RID: 39637
		private static readonly FieldCodec<TowerDefenceRoleInfo> _repeated_roleList_codec = FieldCodec.ForMessage<TowerDefenceRoleInfo>(50U, TowerDefenceRoleInfo.Parser);

		// Token: 0x04009AD6 RID: 39638
		private readonly RepeatedField<TowerDefenceRoleInfo> roleList_ = new RepeatedField<TowerDefenceRoleInfo>();
	}
}
