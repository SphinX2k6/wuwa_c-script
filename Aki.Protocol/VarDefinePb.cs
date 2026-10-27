using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014C6 RID: 5318
	public sealed class VarDefinePb : IMessage<VarDefinePb>, IMessage, IEquatable<VarDefinePb>, IDeepCloneable<VarDefinePb>, IBufferMessage
	{
		// Token: 0x0601C1E3 RID: 115171 RVA: 0x004105E4 File Offset: 0x0040E7E4
		[NullableContext(1)]
		public static VarDefinePb Create()
		{
			return new VarDefinePb();
		}

		// Token: 0x17005EC2 RID: 24258
		// (get) Token: 0x0601C1E4 RID: 115172 RVA: 0x004105EB File Offset: 0x0040E7EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<VarDefinePb> Parser
		{
			get
			{
				return VarDefinePb._parser;
			}
		}

		// Token: 0x17005EC3 RID: 24259
		// (get) Token: 0x0601C1E5 RID: 115173 RVA: 0x004105F2 File Offset: 0x0040E7F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005EC4 RID: 24260
		// (get) Token: 0x0601C1E6 RID: 115174 RVA: 0x004105F5 File Offset: 0x0040E7F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return VarDefinePb.Descriptor;
			}
		}

		// Token: 0x0601C1E7 RID: 115175 RVA: 0x004105FC File Offset: 0x0040E7FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VarDefinePb()
		{
		}

		// Token: 0x0601C1E8 RID: 115176 RVA: 0x00410604 File Offset: 0x0040E804
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VarDefinePb(VarDefinePb other) : this()
		{
			this.varType_ = other.varType_;
			switch (other.ValueCase)
			{
			case VarDefinePb.ValueOneofCase.Boolean:
				this.Boolean = other.Boolean;
				break;
			case VarDefinePb.ValueOneofCase.Int:
				this.Int = other.Int;
				break;
			case VarDefinePb.ValueOneofCase.String:
				this.String = other.String;
				break;
			case VarDefinePb.ValueOneofCase.Float:
				this.Float = other.Float;
				break;
			case VarDefinePb.ValueOneofCase.Entity:
				this.Entity = other.Entity;
				break;
			case VarDefinePb.ValueOneofCase.Quest:
				this.Quest = other.Quest;
				break;
			case VarDefinePb.ValueOneofCase.QuestState:
				this.QuestState = other.QuestState;
				break;
			case VarDefinePb.ValueOneofCase.Transform:
				this.Transform = other.Transform.Clone();
				break;
			case VarDefinePb.ValueOneofCase.Prefab:
				this.Prefab = other.Prefab;
				break;
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C1E9 RID: 115177 RVA: 0x004106ED File Offset: 0x0040E8ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VarDefinePb Clone()
		{
			return new VarDefinePb(this);
		}

		// Token: 0x17005EC5 RID: 24261
		// (get) Token: 0x0601C1EA RID: 115178 RVA: 0x004106F5 File Offset: 0x0040E8F5
		// (set) Token: 0x0601C1EB RID: 115179 RVA: 0x004106FD File Offset: 0x0040E8FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int VarType
		{
			get
			{
				return this.varType_;
			}
			set
			{
				this.varType_ = value;
			}
		}

		// Token: 0x17005EC6 RID: 24262
		// (get) Token: 0x0601C1EC RID: 115180 RVA: 0x00410706 File Offset: 0x0040E906
		// (set) Token: 0x0601C1ED RID: 115181 RVA: 0x0041071D File Offset: 0x0040E91D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Boolean
		{
			get
			{
				return this.HasBoolean && (bool)this.value_;
			}
			set
			{
				this.value_ = value;
				this.valueCase_ = VarDefinePb.ValueOneofCase.Boolean;
			}
		}

		// Token: 0x17005EC7 RID: 24263
		// (get) Token: 0x0601C1EE RID: 115182 RVA: 0x00410732 File Offset: 0x0040E932
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasBoolean
		{
			get
			{
				return this.valueCase_ == VarDefinePb.ValueOneofCase.Boolean;
			}
		}

		// Token: 0x0601C1EF RID: 115183 RVA: 0x0041073D File Offset: 0x0040E93D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearBoolean()
		{
			if (this.HasBoolean)
			{
				this.ClearValue();
			}
		}

		// Token: 0x17005EC8 RID: 24264
		// (get) Token: 0x0601C1F0 RID: 115184 RVA: 0x0041074D File Offset: 0x0040E94D
		// (set) Token: 0x0601C1F1 RID: 115185 RVA: 0x00410765 File Offset: 0x0040E965
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Int
		{
			get
			{
				if (!this.HasInt)
				{
					return 0L;
				}
				return (long)this.value_;
			}
			set
			{
				this.value_ = value;
				this.valueCase_ = VarDefinePb.ValueOneofCase.Int;
			}
		}

		// Token: 0x17005EC9 RID: 24265
		// (get) Token: 0x0601C1F2 RID: 115186 RVA: 0x0041077A File Offset: 0x0040E97A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasInt
		{
			get
			{
				return this.valueCase_ == VarDefinePb.ValueOneofCase.Int;
			}
		}

		// Token: 0x0601C1F3 RID: 115187 RVA: 0x00410785 File Offset: 0x0040E985
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearInt()
		{
			if (this.HasInt)
			{
				this.ClearValue();
			}
		}

		// Token: 0x17005ECA RID: 24266
		// (get) Token: 0x0601C1F4 RID: 115188 RVA: 0x00410795 File Offset: 0x0040E995
		// (set) Token: 0x0601C1F5 RID: 115189 RVA: 0x004107B0 File Offset: 0x0040E9B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string String
		{
			get
			{
				if (!this.HasString)
				{
					return "";
				}
				return (string)this.value_;
			}
			set
			{
				this.value_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
				this.valueCase_ = VarDefinePb.ValueOneofCase.String;
			}
		}

		// Token: 0x17005ECB RID: 24267
		// (get) Token: 0x0601C1F6 RID: 115190 RVA: 0x004107CA File Offset: 0x0040E9CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasString
		{
			get
			{
				return this.valueCase_ == VarDefinePb.ValueOneofCase.String;
			}
		}

		// Token: 0x0601C1F7 RID: 115191 RVA: 0x004107D5 File Offset: 0x0040E9D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearString()
		{
			if (this.HasString)
			{
				this.ClearValue();
			}
		}

		// Token: 0x17005ECC RID: 24268
		// (get) Token: 0x0601C1F8 RID: 115192 RVA: 0x004107E5 File Offset: 0x0040E9E5
		// (set) Token: 0x0601C1F9 RID: 115193 RVA: 0x00410800 File Offset: 0x0040EA00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float Float
		{
			get
			{
				if (!this.HasFloat)
				{
					return 0f;
				}
				return (float)this.value_;
			}
			set
			{
				this.value_ = value;
				this.valueCase_ = VarDefinePb.ValueOneofCase.Float;
			}
		}

		// Token: 0x17005ECD RID: 24269
		// (get) Token: 0x0601C1FA RID: 115194 RVA: 0x00410815 File Offset: 0x0040EA15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasFloat
		{
			get
			{
				return this.valueCase_ == VarDefinePb.ValueOneofCase.Float;
			}
		}

		// Token: 0x0601C1FB RID: 115195 RVA: 0x00410820 File Offset: 0x0040EA20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearFloat()
		{
			if (this.HasFloat)
			{
				this.ClearValue();
			}
		}

		// Token: 0x17005ECE RID: 24270
		// (get) Token: 0x0601C1FC RID: 115196 RVA: 0x00410830 File Offset: 0x0040EA30
		// (set) Token: 0x0601C1FD RID: 115197 RVA: 0x00410847 File Offset: 0x0040EA47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Entity
		{
			get
			{
				if (!this.HasEntity)
				{
					return 0;
				}
				return (int)this.value_;
			}
			set
			{
				this.value_ = value;
				this.valueCase_ = VarDefinePb.ValueOneofCase.Entity;
			}
		}

		// Token: 0x17005ECF RID: 24271
		// (get) Token: 0x0601C1FE RID: 115198 RVA: 0x0041085C File Offset: 0x0040EA5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasEntity
		{
			get
			{
				return this.valueCase_ == VarDefinePb.ValueOneofCase.Entity;
			}
		}

		// Token: 0x0601C1FF RID: 115199 RVA: 0x00410867 File Offset: 0x0040EA67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearEntity()
		{
			if (this.HasEntity)
			{
				this.ClearValue();
			}
		}

		// Token: 0x17005ED0 RID: 24272
		// (get) Token: 0x0601C200 RID: 115200 RVA: 0x00410877 File Offset: 0x0040EA77
		// (set) Token: 0x0601C201 RID: 115201 RVA: 0x0041088E File Offset: 0x0040EA8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Quest
		{
			get
			{
				if (!this.HasQuest)
				{
					return 0;
				}
				return (int)this.value_;
			}
			set
			{
				this.value_ = value;
				this.valueCase_ = VarDefinePb.ValueOneofCase.Quest;
			}
		}

		// Token: 0x17005ED1 RID: 24273
		// (get) Token: 0x0601C202 RID: 115202 RVA: 0x004108A3 File Offset: 0x0040EAA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasQuest
		{
			get
			{
				return this.valueCase_ == VarDefinePb.ValueOneofCase.Quest;
			}
		}

		// Token: 0x0601C203 RID: 115203 RVA: 0x004108AE File Offset: 0x0040EAAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearQuest()
		{
			if (this.HasQuest)
			{
				this.ClearValue();
			}
		}

		// Token: 0x17005ED2 RID: 24274
		// (get) Token: 0x0601C204 RID: 115204 RVA: 0x004108BE File Offset: 0x0040EABE
		// (set) Token: 0x0601C205 RID: 115205 RVA: 0x004108D5 File Offset: 0x0040EAD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int QuestState
		{
			get
			{
				if (!this.HasQuestState)
				{
					return 0;
				}
				return (int)this.value_;
			}
			set
			{
				this.value_ = value;
				this.valueCase_ = VarDefinePb.ValueOneofCase.QuestState;
			}
		}

		// Token: 0x17005ED3 RID: 24275
		// (get) Token: 0x0601C206 RID: 115206 RVA: 0x004108EA File Offset: 0x0040EAEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasQuestState
		{
			get
			{
				return this.valueCase_ == VarDefinePb.ValueOneofCase.QuestState;
			}
		}

		// Token: 0x0601C207 RID: 115207 RVA: 0x004108F5 File Offset: 0x0040EAF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearQuestState()
		{
			if (this.HasQuestState)
			{
				this.ClearValue();
			}
		}

		// Token: 0x17005ED4 RID: 24276
		// (get) Token: 0x0601C208 RID: 115208 RVA: 0x00410905 File Offset: 0x0040EB05
		// (set) Token: 0x0601C209 RID: 115209 RVA: 0x0041091E File Offset: 0x0040EB1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Transform Transform
		{
			get
			{
				if (this.valueCase_ != VarDefinePb.ValueOneofCase.Transform)
				{
					return null;
				}
				return (Transform)this.value_;
			}
			set
			{
				this.value_ = value;
				this.valueCase_ = ((value == null) ? VarDefinePb.ValueOneofCase.None : VarDefinePb.ValueOneofCase.Transform);
			}
		}

		// Token: 0x17005ED5 RID: 24277
		// (get) Token: 0x0601C20A RID: 115210 RVA: 0x00410935 File Offset: 0x0040EB35
		// (set) Token: 0x0601C20B RID: 115211 RVA: 0x0041094D File Offset: 0x0040EB4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Prefab
		{
			get
			{
				if (!this.HasPrefab)
				{
					return 0L;
				}
				return (long)this.value_;
			}
			set
			{
				this.value_ = value;
				this.valueCase_ = VarDefinePb.ValueOneofCase.Prefab;
			}
		}

		// Token: 0x17005ED6 RID: 24278
		// (get) Token: 0x0601C20C RID: 115212 RVA: 0x00410963 File Offset: 0x0040EB63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasPrefab
		{
			get
			{
				return this.valueCase_ == VarDefinePb.ValueOneofCase.Prefab;
			}
		}

		// Token: 0x0601C20D RID: 115213 RVA: 0x0041096F File Offset: 0x0040EB6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearPrefab()
		{
			if (this.HasPrefab)
			{
				this.ClearValue();
			}
		}

		// Token: 0x17005ED7 RID: 24279
		// (get) Token: 0x0601C20E RID: 115214 RVA: 0x0041097F File Offset: 0x0040EB7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VarDefinePb.ValueOneofCase ValueCase
		{
			get
			{
				return this.valueCase_;
			}
		}

		// Token: 0x0601C20F RID: 115215 RVA: 0x00410987 File Offset: 0x0040EB87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearValue()
		{
			this.valueCase_ = VarDefinePb.ValueOneofCase.None;
			this.value_ = null;
		}

		// Token: 0x0601C210 RID: 115216 RVA: 0x00410997 File Offset: 0x0040EB97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as VarDefinePb);
		}

		// Token: 0x0601C211 RID: 115217 RVA: 0x004109A8 File Offset: 0x0040EBA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(VarDefinePb other)
		{
			return other != null && (other == this || (this.VarType == other.VarType && this.Boolean == other.Boolean && this.Int == other.Int && !(this.String != other.String) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Float, other.Float) && this.Entity == other.Entity && this.Quest == other.Quest && this.QuestState == other.QuestState && object.Equals(this.Transform, other.Transform) && this.Prefab == other.Prefab && this.ValueCase == other.ValueCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C212 RID: 115218 RVA: 0x00410A98 File Offset: 0x0040EC98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.VarType != 0)
			{
				num ^= this.VarType.GetHashCode();
			}
			if (this.HasBoolean)
			{
				num ^= this.Boolean.GetHashCode();
			}
			if (this.HasInt)
			{
				num ^= this.Int.GetHashCode();
			}
			if (this.HasString)
			{
				num ^= this.String.GetHashCode();
			}
			if (this.HasFloat)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.Float);
			}
			if (this.HasEntity)
			{
				num ^= this.Entity.GetHashCode();
			}
			if (this.HasQuest)
			{
				num ^= this.Quest.GetHashCode();
			}
			if (this.HasQuestState)
			{
				num ^= this.QuestState.GetHashCode();
			}
			if (this.valueCase_ == VarDefinePb.ValueOneofCase.Transform)
			{
				num ^= this.Transform.GetHashCode();
			}
			if (this.HasPrefab)
			{
				num ^= this.Prefab.GetHashCode();
			}
			num ^= (int)this.valueCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C213 RID: 115219 RVA: 0x00410BBF File Offset: 0x0040EDBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C214 RID: 115220 RVA: 0x00410BCC File Offset: 0x0040EDCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C215 RID: 115221 RVA: 0x00410BD8 File Offset: 0x0040EDD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.VarType != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.VarType);
			}
			if (this.HasBoolean)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.Boolean);
			}
			if (this.HasInt)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.Int);
			}
			if (this.HasString)
			{
				output.WriteRawTag(34);
				output.WriteString(this.String);
			}
			if (this.HasFloat)
			{
				output.WriteRawTag(45);
				output.WriteFloat(this.Float);
			}
			if (this.HasEntity)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.Entity);
			}
			if (this.HasQuest)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.Quest);
			}
			if (this.HasQuestState)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.QuestState);
			}
			if (this.valueCase_ == VarDefinePb.ValueOneofCase.Transform)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.Transform);
			}
			if (this.HasPrefab)
			{
				output.WriteRawTag(80);
				output.WriteInt64(this.Prefab);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C216 RID: 115222 RVA: 0x00410D14 File Offset: 0x0040EF14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.VarType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.VarType);
			}
			if (this.HasBoolean)
			{
				num += 2;
			}
			if (this.HasInt)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Int);
			}
			if (this.HasString)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.String);
			}
			if (this.HasFloat)
			{
				num += 5;
			}
			if (this.HasEntity)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Entity);
			}
			if (this.HasQuest)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Quest);
			}
			if (this.HasQuestState)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.QuestState);
			}
			if (this.valueCase_ == VarDefinePb.ValueOneofCase.Transform)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Transform);
			}
			if (this.HasPrefab)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Prefab);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C217 RID: 115223 RVA: 0x00410E14 File Offset: 0x0040F014
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(VarDefinePb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.VarType != 0)
			{
				this.VarType = other.VarType;
			}
			switch (other.ValueCase)
			{
			case VarDefinePb.ValueOneofCase.Boolean:
				this.Boolean = other.Boolean;
				break;
			case VarDefinePb.ValueOneofCase.Int:
				this.Int = other.Int;
				break;
			case VarDefinePb.ValueOneofCase.String:
				this.String = other.String;
				break;
			case VarDefinePb.ValueOneofCase.Float:
				this.Float = other.Float;
				break;
			case VarDefinePb.ValueOneofCase.Entity:
				this.Entity = other.Entity;
				break;
			case VarDefinePb.ValueOneofCase.Quest:
				this.Quest = other.Quest;
				break;
			case VarDefinePb.ValueOneofCase.QuestState:
				this.QuestState = other.QuestState;
				break;
			case VarDefinePb.ValueOneofCase.Transform:
				if (this.Transform == null)
				{
					this.Transform = new Transform();
				}
				this.Transform.MergeFrom(other.Transform);
				break;
			case VarDefinePb.ValueOneofCase.Prefab:
				this.Prefab = other.Prefab;
				break;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C218 RID: 115224 RVA: 0x00410F1F File Offset: 0x0040F11F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C219 RID: 115225 RVA: 0x00410F28 File Offset: 0x0040F128
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
				if (num <= 45U)
				{
					if (num <= 16U)
					{
						if (num == 8U)
						{
							this.VarType = input.ReadInt32();
							continue;
						}
						if (num == 16U)
						{
							this.Boolean = input.ReadBool();
							continue;
						}
					}
					else
					{
						if (num == 24U)
						{
							this.Int = input.ReadInt64();
							continue;
						}
						if (num == 34U)
						{
							this.String = input.ReadString();
							continue;
						}
						if (num == 45U)
						{
							this.Float = input.ReadFloat();
							continue;
						}
					}
				}
				else if (num <= 56U)
				{
					if (num == 48U)
					{
						this.Entity = input.ReadInt32();
						continue;
					}
					if (num == 56U)
					{
						this.Quest = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 64U)
					{
						this.QuestState = input.ReadInt32();
						continue;
					}
					if (num == 74U)
					{
						Transform transform = new Transform();
						if (this.valueCase_ == VarDefinePb.ValueOneofCase.Transform)
						{
							transform.MergeFrom(this.Transform);
						}
						input.ReadMessage(transform);
						this.Transform = transform;
						continue;
					}
					if (num == 80U)
					{
						this.Prefab = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400A163 RID: 41315
		private static readonly MessageParser<VarDefinePb> _parser = new MessageParser<VarDefinePb>(() => new VarDefinePb());

		// Token: 0x0400A164 RID: 41316
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A165 RID: 41317
		public const int VarTypeFieldNumber = 1;

		// Token: 0x0400A166 RID: 41318
		private int varType_;

		// Token: 0x0400A167 RID: 41319
		public const int BooleanFieldNumber = 2;

		// Token: 0x0400A168 RID: 41320
		public const int IntFieldNumber = 3;

		// Token: 0x0400A169 RID: 41321
		public const int StringFieldNumber = 4;

		// Token: 0x0400A16A RID: 41322
		public const int FloatFieldNumber = 5;

		// Token: 0x0400A16B RID: 41323
		public const int EntityFieldNumber = 6;

		// Token: 0x0400A16C RID: 41324
		public const int QuestFieldNumber = 7;

		// Token: 0x0400A16D RID: 41325
		public const int QuestStateFieldNumber = 8;

		// Token: 0x0400A16E RID: 41326
		public const int TransformFieldNumber = 9;

		// Token: 0x0400A16F RID: 41327
		public const int PrefabFieldNumber = 10;

		// Token: 0x0400A170 RID: 41328
		private object value_;

		// Token: 0x0400A171 RID: 41329
		private VarDefinePb.ValueOneofCase valueCase_;

		// Token: 0x020019EB RID: 6635
		public enum ValueOneofCase
		{
			// Token: 0x0400CAC8 RID: 51912
			None,
			// Token: 0x0400CAC9 RID: 51913
			Boolean = 2,
			// Token: 0x0400CACA RID: 51914
			Int,
			// Token: 0x0400CACB RID: 51915
			String,
			// Token: 0x0400CACC RID: 51916
			Float,
			// Token: 0x0400CACD RID: 51917
			Entity,
			// Token: 0x0400CACE RID: 51918
			Quest,
			// Token: 0x0400CACF RID: 51919
			QuestState,
			// Token: 0x0400CAD0 RID: 51920
			Transform,
			// Token: 0x0400CAD1 RID: 51921
			Prefab
		}
	}
}
