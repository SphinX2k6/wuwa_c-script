using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001071 RID: 4209
	[NetMessage(EMessageId.RoleFavorFinishConditionNotify)]
	public sealed class RoleFavorFinishConditionNotify : IMessage<RoleFavorFinishConditionNotify>, IMessage, IEquatable<RoleFavorFinishConditionNotify>, IDeepCloneable<RoleFavorFinishConditionNotify>, IBufferMessage
	{
		// Token: 0x060167E1 RID: 92129 RVA: 0x003452B7 File Offset: 0x003434B7
		[NullableContext(1)]
		public static RoleFavorFinishConditionNotify Create()
		{
			return new RoleFavorFinishConditionNotify();
		}

		// Token: 0x17004B50 RID: 19280
		// (get) Token: 0x060167E2 RID: 92130 RVA: 0x003452BE File Offset: 0x003434BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004B51 RID: 19281
		// (get) Token: 0x060167E3 RID: 92131 RVA: 0x003452C1 File Offset: 0x003434C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleFavorFinishConditionNotify.Descriptor;
			}
		}

		// Token: 0x060167E4 RID: 92132 RVA: 0x003452C8 File Offset: 0x003434C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFavorFinishConditionNotify()
		{
		}

		// Token: 0x060167E5 RID: 92133 RVA: 0x003452DB File Offset: 0x003434DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFavorFinishConditionNotify(RoleFavorFinishConditionNotify other) : this()
		{
			this.roleConditionInfoMap_ = other.roleConditionInfoMap_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060167E6 RID: 92134 RVA: 0x00345305 File Offset: 0x00343505
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFavorFinishConditionNotify Clone()
		{
			return new RoleFavorFinishConditionNotify(this);
		}

		// Token: 0x17004B52 RID: 19282
		// (get) Token: 0x060167E7 RID: 92135 RVA: 0x0034530D File Offset: 0x0034350D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, ConditionInfo> RoleConditionInfoMap
		{
			get
			{
				return this.roleConditionInfoMap_;
			}
		}

		// Token: 0x060167E8 RID: 92136 RVA: 0x00345315 File Offset: 0x00343515
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleFavorFinishConditionNotify);
		}

		// Token: 0x060167E9 RID: 92137 RVA: 0x00345323 File Offset: 0x00343523
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleFavorFinishConditionNotify other)
		{
			return other != null && (other == this || (this.RoleConditionInfoMap.Equals(other.RoleConditionInfoMap) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060167EA RID: 92138 RVA: 0x00345358 File Offset: 0x00343558
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.RoleConditionInfoMap.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060167EB RID: 92139 RVA: 0x0034538C File Offset: 0x0034358C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060167EC RID: 92140 RVA: 0x00345399 File Offset: 0x00343599
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060167ED RID: 92141 RVA: 0x003453A2 File Offset: 0x003435A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.roleConditionInfoMap_.WriteTo(ref output, RoleFavorFinishConditionNotify._map_roleConditionInfoMap_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060167EE RID: 92142 RVA: 0x003453CC File Offset: 0x003435CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.roleConditionInfoMap_.CalculateSize(RoleFavorFinishConditionNotify._map_roleConditionInfoMap_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060167EF RID: 92143 RVA: 0x00345405 File Offset: 0x00343605
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleFavorFinishConditionNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.roleConditionInfoMap_.MergeFrom(other.roleConditionInfoMap_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060167F0 RID: 92144 RVA: 0x00345433 File Offset: 0x00343633
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060167F1 RID: 92145 RVA: 0x0034543C File Offset: 0x0034363C
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
					this.roleConditionInfoMap_.AddEntriesFrom(ref input, RoleFavorFinishConditionNotify._map_roleConditionInfoMap_codec);
				}
			}
		}

		// Token: 0x04008689 RID: 34441
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400868A RID: 34442
		public const int RoleConditionInfoMapFieldNumber = 4;

		// Token: 0x0400868B RID: 34443
		private static readonly MapField<int, ConditionInfo>.Codec _map_roleConditionInfoMap_codec = new MapField<int, ConditionInfo>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForMessage<ConditionInfo>(18U, ConditionInfo.Parser), 34U);

		// Token: 0x0400868C RID: 34444
		private readonly MapField<int, ConditionInfo> roleConditionInfoMap_ = new MapField<int, ConditionInfo>();
	}
}
